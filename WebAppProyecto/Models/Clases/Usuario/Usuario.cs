﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProyecto.Models.Clases.Usuario
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string passwordTwo { get; set; }
        public string estado { get; set; }
        //public int idRango { get; set; }
        //public int idPerteneciente { get; set; }


        public Usuario() { }

        public Usuario(int IdUsuario, string Usuario, string Password, string Estado)
        {
            idUsuario = IdUsuario;
            usuario = Usuario;
            password = Password;
            estado = Estado;
            //idRango = IdRango;
            //idPerteneciente = IdPerteneciente;
        }

        public Usuario(string Usuario, string Password, string Estado)
        {
            usuario = Usuario;
            password = Password;
            estado = Estado;
            //idRango = IdRango;
            //idPerteneciente = IdPerteneciente;
        }

    }
}