using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IFacturasRepositorio
    {
        List<Facturas> Listar();
        List<Facturas> Buscar(Expression<Func<Facturas, bool>> condiciones);
        Facturas Guardar(Facturas entidad);
        Facturas Modificar(Facturas entidad);
        Facturas Borrar(Facturas entidad);
       
    }
}
