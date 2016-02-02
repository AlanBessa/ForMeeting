using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Infra.Data.Repositorios
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
    }
}
