﻿using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Domain.Site.Interfaces.Repositorios
{
    public interface IComentarioRepository : IBaseRepository<Comentario>
    {
        IEnumerable<Comentario> ObterTodosPorEventoId(Guid idEvento);
    }
}
