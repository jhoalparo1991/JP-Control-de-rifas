using CDatos;
using CEntidades;
using System.Collections.Generic;

namespace CNegocio
{
    public class N_Boletas
    {
        public static List<Boletas> mostrarBoletasPaginadas(int rifaId, int desde, int hasta)
        {
            return D_Boletas.mostrarBoletasPaginadas(rifaId, desde, hasta);
        }
        public static List<DtoMostrarAbonos> mostrarAbonos(int boletaId)
        {
            return D_Boletas.mostrarAbonos(boletaId);
        }
        public static void contarBoletas(ref int total, int id)
        {
            D_Boletas.contarBoletas(ref total, id);
        }

        public static bool registrarAbonosBoletas(AbonosBoletas obj)
        {
            return D_Boletas.registrarAbonosBoletas(obj);
        }

        public static List<DtoMostrarBoletasDatos> mostrarTodasBoletas()
        {
            return D_Boletas.mostrarTodasBoletas();
        }
        public static List<DtoMostrarAsignarBoletasVendedores> mostrarBoletasAsignadasVendedores()
        {
            return D_Boletas.mostrarBoletasAsignadasVendedores();
        }
        public static bool asignarBoletasVendedores(AsignarBoletasVendedores obj)
        {
            return D_Boletas.asignarBoletasVendedores(obj);
        }

        public static bool borrarBoletaAsignadaVendedor(int boletaId)
        {
            return D_Boletas.borrarBoletaAsignadaVendedor(boletaId);
        }
    }
}
