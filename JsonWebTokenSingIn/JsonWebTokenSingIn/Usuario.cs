﻿namespace JsonWebTokenSingIn
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string usuario { get; set; }

        public string password { get; set; }
        public string rol { get; set; }

        public static List<Usuario> DB() 
        {
            var list = new List<Usuario>()
            {
                new Usuario
                {
                    idUsuario = "1",
                    usuario = "Yarni",
                    password = "1234",
                    rol = "Admin"
                },
                 new Usuario
                {
                    idUsuario = "1",
                    usuario = "Eduardo",
                    password = "1234",
                    rol = "Admin"
                },
                  new Usuario
                {
                    idUsuario = "1",
                    usuario = "Rolando",
                    password = "1234",
                    rol = "Admin"
                }
            };

            return list;
        }
    }
}
