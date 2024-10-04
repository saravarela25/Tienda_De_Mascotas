﻿using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IMascotasRepositorio
    {
        List<Mascotas> Listar();
        List<Mascotas> Buscar(Expression<Func<Mascotas, bool>> condiciones);
        Mascotas Guardar(Mascotas entidad);
        Mascotas Modificar(Mascotas entidad);
        Mascotas Borrar(Mascotas entidad);
    }
}
