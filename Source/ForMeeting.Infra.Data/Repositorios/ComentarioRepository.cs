using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Infra.Data.Repositorios
{
    public class ComentarioRepository : BaseRepository<Comentario>, IComentarioRepository
    {
        public override IEnumerable<Comentario> ObterTodos()
        {
            var sql = @"SELECT * FROM TB_COMENTARIO com ";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();

                var comentario = cn.Query<Comentario>(sql);

                return comentario;
            }
        }

        public IEnumerable<Comentario> ObterTodosPorEventoId(Guid idEvento)
        {
            var sql = @"SELECT * FROM TB_COMENTARIO com 
                        inner join TB_EVENTO e on com.EventoId = e.IdEvento
                        where e.IdEvento = @sid";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();

                var listaDeComentarios = cn.Query<Comentario, Evento, Comentario>(sql,
                    (com, e) =>
                    {
                        com.Evento = e;
                        return com;
                    }, new { sid = idEvento });

                return listaDeComentarios;
            }
        }
    }
}
