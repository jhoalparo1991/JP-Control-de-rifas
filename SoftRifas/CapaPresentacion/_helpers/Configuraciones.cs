using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CapaPresentacion._helpers
{
    internal class Configuraciones
    {
        public static string _DIRECTORIO = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SoftRifas");
        private static string _ARCHIVO_DB = Path.Combine(_DIRECTORIO, "connection_string.txt");

        public static async Task crearArchivoConfConexionDB(ProcesoConexion proceso)
        {
            bool resultDirectorio = crearDirectorio();
            await crearArchivoconexionDB(proceso);
        }

        private static bool crearDirectorio()
        {
            if (!Directory.Exists(_DIRECTORIO))
            {
                Directory.CreateDirectory(_DIRECTORIO);
                return true;
            }

            return false;
        }

        private static async Task crearArchivoconexionDB(ProcesoConexion proceso)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_ARCHIVO_DB))
                {
                    await writer.WriteLineAsync(proceso.Servidor);
                    await writer.WriteLineAsync(proceso.BaseDeDatos);
                    await writer.WriteLineAsync(proceso.Usuario);
                    await writer.WriteLineAsync(proceso.Password);
                    await writer.WriteLineAsync(proceso.SeguridadIntegrada.ToString());
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        public static List<string> LeerArchivoconexionDB()
        {

            List<string> listado = new List<string>();

            try
            {
                if (File.Exists(_ARCHIVO_DB))
                {
                    using (StreamReader reader = new StreamReader(_ARCHIVO_DB))
                    {
                        string lineas;
                        while ((lineas = reader.ReadLine()) != null)
                        {
                            listado.Add(lineas);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }

            return listado;
        }

        public static bool probarConexion()
        {
            bool result = false;
            try
            {
                List<string> properties = LeerArchivoconexionDB();

                if (properties == null || properties.Count <= 0)
                {
                    result = false;
                }
                else
                {
                    ProcesoConexion proceso = new ProcesoConexion()
                    {
                        Servidor = properties[0],
                        BaseDeDatos = properties[1],
                        Usuario = properties[2],
                        Password = properties[3],
                        SeguridadIntegrada = Convert.ToBoolean(properties[4]),
                    };


                    if (N_Procesos.getConnectionTest())
                    {

                        result = true;

                    }
                    else
                    {
                        result = false;
                    }

                }


            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }

            return result;
        }


    }
}
