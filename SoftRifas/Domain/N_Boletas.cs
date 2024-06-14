using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Domain
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
        public static bool cambiarFormaPagoBoleta(int abonoBoletaId, string formaPago)
        {
            return D_Boletas.cambiarFormaPagoBoleta(abonoBoletaId, formaPago);
        }
        public static DataTable consultarAbonosEntreFechasAndVendedor(int vendedorId, DateTime FIni, DateTime FFin)
        {
            return D_Boletas.consultarAbonosEntreFechasAndVendedor(vendedorId, FIni, FFin);
        }

        public static DataTable obtenerBoletasEntreFechasAndVendedor(int vendedorId, DateTime FIni, DateTime FFin, string codigo)
        {
            return D_Boletas.obtenerBoletasEntreFechasAndVendedor(vendedorId, FIni, FFin,codigo);
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

        public static bool borrarAbonosBoletas(int boletaId, int idAbonoBoleta, int vendedorId)
        {
            return D_Boletas.borrarAbonosBoletas(boletaId, idAbonoBoleta, vendedorId);
        }

        public static bool cambiarClienteBoleta(int boletaId, int clienteId)
        {
            return D_Boletas.cambiarClienteBoleta(boletaId, clienteId);
        }

    }
}
