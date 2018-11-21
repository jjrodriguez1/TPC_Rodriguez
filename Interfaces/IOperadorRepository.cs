using DLL;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IOperadorRepository
    {
        Operador LoginOperador(string usuario, string password);
        bool AltaOperador(Operador operador);
        List<OperadorLista> GetOperadores();
        Operador GetOperadorById(int id);
        bool ModificarOperador(Operador operador);
        List<OperadorLista> GetByName(string nombre);
        List<OperadorLista> GetByDocument(string documento);
    }
}
