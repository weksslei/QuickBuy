﻿using Quick.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quick.Dominio.Contratos
{
    public interface IUsuarioRepositorio: IBaseReposotorio<Usuario>
    {
        Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
