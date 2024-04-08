using Microsoft.EntityFrameworkCore;
using H20240408;

namespace H20240408.AccesoADatos
{

    public class PersonaHDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaHDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<int> Crear(PersonaH personaH)
        {
            _appDbContext.Add(personaH);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaH personaH)
        {
            var personaHData = await _appDbContext.PersonasH.FirstOrDefaultAsync(s => s.Id == personaH.Id);
            if (personaHData != null)
            {
                personaHData.NombreH = personaH.NombreH;
                personaHData.ApellidoH = personaH.ApellidoH;
                personaHData.FechaNacimientoH = personaH.FechaNacimientoH;
                personaHData.SueldoH = personaH.SueldoH;
                personaHData.EstatusH = personaH.EstatusH;
                personaHData.ComentarioH = personaH.ComentarioH;
                _appDbContext.Update(personaHData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaH personaH)
        {
            var personaHData = await _appDbContext.PersonasH.FirstOrDefaultAsync(s => s.Id == personaH.Id);
            if (personaHData != null)
                _appDbContext.Remove(personaHData);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<PersonaH> ObtenerPorId(PersonaH personaH)
        {
            var personaHData = await _appDbContext.PersonasH.FirstOrDefaultAsync(s => s.Id == personaH.Id);
            if (personaHData != null)
                return personaHData;
            else
                return new PersonaH();
        }
        public async Task<List<PersonaH>> ObtenerTodos()
        {
            return await _appDbContext.PersonasH.ToListAsync();
        }
        public async Task<List<PersonaH>> Buscar(PersonaH personaH)
        {

            var query = _appDbContext.PersonasH.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaH.NombreH))
            {
                query = query.Where(s => s.NombreH.Contains(personaH.NombreH));
            }
            if (!string.IsNullOrWhiteSpace(personaH.ApellidoH))
            {
                query = query.Where(s => s.ApellidoH.Contains(personaH.ApellidoH));
            }
            if (personaH.EstatusH == 1 || personaH.EstatusH == 2)
            {
                query = query.Where(s => s.EstatusH == personaH.EstatusH);
            }
            if (personaH.Take == 0)
                personaH.Take = 10;
            query = query.Take(personaH.Take);

            return await query.ToListAsync();

        }
    }
}
