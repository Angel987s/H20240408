using H20240408.AccesoADatos;


namespace H20240408.LogicaDeNegocio
{
    public class PersonaHBL
    {
        readonly PersonaHDAL _personaHDAL;
        public PersonaHBL(PersonaHDAL personaHDAL)
        {
            _personaHDAL = personaHDAL;
        }
        public async Task<int> Crear(PersonaH personaH)
        {
            return await _personaHDAL.Crear(personaH);
        }
        public async Task<int> Modificar(PersonaH personaH)
        {
            return await _personaHDAL.Modificar(personaH);
        }
        public async Task<int> Eliminar(PersonaH personaH)
        {
            return await _personaHDAL.Eliminar(personaH);
        }
        public async Task<PersonaH> ObtenerPorId(PersonaH personaH)
        {
            return await _personaHDAL.ObtenerPorId(personaH);
        }
        public async Task<List<PersonaH>> ObtenerTodos()
        {
            return await _personaHDAL.ObtenerTodos();
        }
        public async Task<List<PersonaH>> Buscar(PersonaH personaH)
        {
            return await _personaHDAL.Buscar(personaH);
        }
    }
}