using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class Mascotas_ClientesPruebaUnitaria
    {
        private IMascotas_ClientesRepositorio? iRepositorio = null;
        private Mascotas_Clientes? entidad = null;

        public Mascotas_ClientesPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-KLUPRVA\\DEV;database=db_Tienda_MASCOTAS;Integrated Security=True;TrustServerCertificate=True;";
            iRepositorio = new Mascotas_ClientesRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }

        private void Guardar()
        {
            entidad = new Mascotas_Clientes()
            {
                Cliente=1,
                Mascota=3,
                
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        public void Buscar()
        {
            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Modificar()
        {
            entidad!.Cliente = 2;
            entidad = iRepositorio!.Modificar(entidad!);

            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }

    }
}
