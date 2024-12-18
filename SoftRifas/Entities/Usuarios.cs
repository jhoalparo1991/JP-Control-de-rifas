﻿using System;

namespace Entities
{
    public class Usuarios
    {

        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Clave { get; set; }
        public decimal Comision { get; set; }
        public bool Activo { get; set; }
    }

    public class UsuariosPermisos
    {
        public bool Vendedores { get; set; }
        public bool Clientes { get; set; }
        public bool Rifas { get; set; }
        public bool Boletas { get; set; }
        public bool PagoComisiones { get; set; }
        public bool Reportes { get; set; }
        public bool Egresos { get; set; }
        public bool CrearTipoEgreso { get; set; }
        public bool BorrarEgreso { get; set; }
        public bool EditarEgreso { get; set; }
        public bool CrearEgreso { get; set; }
        public bool ImprimirEgreso { get; set; }
        public bool CrearCopiaSeguridad { get; set; }
        public bool RegistrarAbono { get; set; }
        public bool BorrarAbono { get; set; }
        public bool CambiarFpAbono { get; set; }
        public bool CambiarClienteAbono { get; set; }
        public bool CrearVendedores { get; set; }
        public bool EditarVendedores { get; set; }
        public bool BorrarVendedores { get; set; }
        public bool AsignarBoletasVendedores { get; set; }
        public bool VerLog { get; set; }
        public bool VerBoleta { get; set; }
        public bool DesbloquearBoleta { get; set; }
        //Nuevos permisos
        public bool ver_estado_boletas { get; set; }
        public bool ver_caja { get; set; }
        public bool ver_acumulado { get; set; }
        public bool ver_todos_los_abonos { get; set; }
        public bool ver_abonos_totales_por_clientes { get; set; }
        public bool ver_comisiones_vendedores_pagada { get; set; }
        public bool ver_abonos_por_vendedores { get; set; }
        public bool ver_abonos_por_boletas { get; set; }
        public bool ver_boletas_vendidas { get; set; }
        public bool ver_formas_pago { get; set; }
        public bool ver_filtrar_abonos_fecha_valor { get; set; }
        public bool ver_comisiones_pagadas { get; set; }
        public bool ver_gastos { get; set; }
        public bool ver_reporte_abono_formas_pago { get; set; }
        public bool ver_reporte_boletas_entre_fechas { get; set; }
    }

    public class InicioSesion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NombreCompleto { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
