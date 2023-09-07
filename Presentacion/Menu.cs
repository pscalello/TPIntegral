using Entidad;
using Negocio;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Presentacion // Note: actual namespace depends on the project name.HOLA
{
    static void Main(string[] args)
    {
        UsuarioN UsuarioNuevo = new UsuarioN();

        // Hardcodeo de 3 usuarios: un Administrador, un supervisor y un endedor

        //ADMINISTRADOR: Se instancia la entidad para que esté ACTIVO y con Pasword no genérica
        // Creación persistente de administrador
        UsuarioE Administrador = new UsuarioE("SOFIA", "GONZALEZ", "Rivadavia 333", "4444-5555", "admin@gmail.com", new DateTime(2023, 1, 1),
                                       new DateTime(2000, 6, 15), new DateTime(2023, 8, 1), "Administrador", 1, 40222888, "Admin1234");
        UsuarioN.Usuarios.Add(Administrador);


        //SUPERVISOR: Se usa método "CearUsuario" de "NEGOCIO" para ponerlo inactivo y con clave genérica
        UsuarioNuevo.CrearUsuario("JUAN", "RAMIREZ", "Rivadavia 333", "8888-6666", "supervisor@gmail.com", new DateTime(2023, 1, 1),
                                   new DateTime(2005, 7, 15), "Supervisor", 2, 30252997);


        //VENDEDOR: Se usa método "CearUsuario" de "NEGOCIO" para ponerlo inactivo y con clave genérica
        UsuarioNuevo.CrearUsuario("ROBERTO", "CARRIZO", "Rivadavia 333", "9999-5555", "vendedor@gmail.com", new DateTime(2023, 1, 1),
                       new DateTime(2003, 9, 8), "Vendedor", 3, 40222333);



        MenuPrincipal();

    }

    //***************************************************************************************************************************** 
    //                                                  MENU PRINCIPAL                                                           //
    //*****************************************************************************************************************************


    static void MenuPrincipal()
    {
        // VARIABLES NECESARIAS //
        bool salir = false;
        int OpcionMenu;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TP INTEGRAL CAI 2 - BIENVENIDA \n" +
                                "Elija la opción deseada: \n" +
                                "1 - Ingresar al Sistema \n" +
                                "2 - Registrarse \n" +
                                "3 - Salir \n");
            OpcionMenu = Utils.PedirEntre(1, 3, ""); // hasta que no ingresa 1 o 2, tira error
            switch (OpcionMenu)
            {
                case 1:
                    PantallaLogin();
                    break;
                case 2:
                    PantallaRegistroClientes();
                    break;
                case 3:
                    salir = true;
                    break;
            }
        }

        Console.WriteLine("Gracias por utilizar el sistema! Presione cualquier tecla para terminar");
        Console.ReadKey();
    }

    //***************************************************************************************************************************** 
    //                                                  PANTALLA LOGIN                                                           //
    //*****************************************************************************************************************************


    static void PantallaLogin()
    {
        bool salir = false;
        int hostUsuario, intentos = 1;
        UsuarioN UsuarioNuevo = new UsuarioN();

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TP INTEGRAL CAI 2 - LOGIN \n");

            string NombreUsuario, password;

            NombreUsuario = Utils.PedirPalabra("Ingrese su nombre de usuario:\n");
            password = Utils.PedirPalabra("Ingrese su password:\n");

            // valida Nombre Usuario y Password por negocio y recibe 1 si es admin, 2 si es supervisor, 3 si es vendedor,
            // 0 si no coincide pass y usuario y -1 si agotó intentos

            hostUsuario = UsuarioNuevo.AutenticarUsuario(NombreUsuario, password, intentos);

            switch (hostUsuario)
            {
                case -1:
                    Console.WriteLine("Se agotaron sus intentos, comuníquese con un administrador. Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    salir = true;
                    break;
                case 0:
                    Console.WriteLine("Nombre de Usuario o Password incorrecto. Inténtelo nuevamente.");
                    Console.ReadKey();
                    intentos += 1;
                    break;
                case 1:
                    MenuAdministrador();
                    salir = true;
                    break;
                case 2:
                    MenuSupervisor();
                    salir = true;
                    break;
                case 3:
                    MenuVendedor();
                    salir = true;
                    break;
            }
        }
    }

    //***************************************************************************************************************************** 
    //                                                  REGISTRO CLIENTES                                                        //
    //*****************************************************************************************************************************

    static void PantallaRegistroClientes()
    {
        bool salir = false;

        UsuarioN UsuarioNNuevo = new UsuarioN();

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TP INTEGRAL CAI 2 - LOGIN \n" +
                                "Esta opción de Auto Registro estará disponible en versiones posteriores para clientes. \n" +
                                "Sólo se pueden registrar Supervisores y Vendedores mediante el login de un Administrador. \n" +
                                "Presiones cualquier tecla para volver al menú anterior.");

            Console.ReadKey();
            salir = true;
        }
    }


    //***************************************************************************************************************************** 
    //***************************************************************************************************************************** 
    //                                                  MENU ADMINISTRADOR                                                       //
    //***************************************************************************************************************************** 
    //***************************************************************************************************************************** 

    static void MenuAdministrador()
    {
        bool salir = false;
        int OpcionMenu;
        //UsuarioN UsuarioNNuevo = new UsuarioN();

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TP INTEGRAL CAI 2 - Menú Administrador \n\n" +
                                "Elija la opción deseada: \n\n" +
                                "------ ABM USUARIOS ------ \n" +
                                "1 - Alta de Usuarios \n" +
                                "2 - Modificación de Usuarios \n" +
                                "3 - Baja de usuarios \n" +
                                "4 - Consulta de usuarios \n\n" +
                                "------ ABM PROVEEDORES ------ \n" +
                                "5 - Alta de Proveedores \n" +
                                "6 - Modificación de Proveedores \n" +
                                "7 - Baja de Proveedores \n" +
                                "8 - Consulta de Proveedores \n\n" +
                                "------ ABM PRODUCTOS ------ \n" +
                                "9 - Alta de Productos \n" +
                                "10 - Modificación de Productos \n" +
                                "10 - Baja de Productos \n" +
                                "11 - Consulta Productos \n\n" +
                                "------ REPORTES ------ \n" +
                                "12 - Reporte de Stock Crítico \n" +
                                "13 - Reporte de Ventas por Vendedor \n" +
                                "14 - Reporte de Productos más vendido por categoría \n\n" +
                                "------------------------------ \n" +
                                "0 - Volver al menú principal \n");
            OpcionMenu = Utils.PedirEntre(0, 14, ""); // hasta que no ingresa un nro de 0 a 14, error

            switch (OpcionMenu)
            {
                case 0:
                    MenuPrincipal();
                    salir = true;
                    break;
                case 1:
                    AltaUsuarios();
                    break;
                case 2:
                    //PantallaRegistroClientes();
                    break;
                case 3:
                    //salir = true;
                    break;
                case 4:
                    ConsultaUsuarios();
                    //salir = true;
                    break;
                // de 9 a 14 deshabilitadas de momento:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Estas opciones estarán habilitadas en futuras versiones. Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    //MenuPrincipal();
                    //salir = true;
                    break;
            }
        }
    }


    //***************************************************************************************************************************** 
    //***************************************************************************************************************************** 
    //                                                  MENU SUPERVISOR                                                          //
    //***************************************************************************************************************************** 
    //***************************************************************************************************************************** 


    static void MenuSupervisor()
    {
        bool salir = false;
        int OpcionMenu;
        //UsuarioN UsuarioNNuevo = new UsuarioN();

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TP INTEGRAL CAI 2 - Menú Supervisor \n\n" +
                                "Elija la opción deseada: \n\n" +
                                "------ ABM PRODUCTOS ------ \n" +
                                "1 - Alta de Productos \n" +
                                "2 - Modificación de Productos \n" +
                                "3 - Baja de Productos \n" +
                                "4 - Consulta Productos \n\n" +
                                "------ REPORTES ------ \n" +
                                "5 - Reporte de Stock Crítico \n" +
                                "6 - Reporte de Ventas por Vendedor \n" +
                                "7 - Reporte de Productos más vendido por categoría \n\n" +
                                "------ VENTAS ------ \n" +
                                "8 - Devoluciones \n\n" +
                                "------------------------------ \n" +
                                "0 - Volver al menú principal \n");
            OpcionMenu = Utils.PedirEntre(0, 8, ""); // hasta que no ingresa un nro de 0 a 8, error

            switch (OpcionMenu)
            {
                case 0:
                    MenuPrincipal();
                    salir = true;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Estas opciones estarán habilitadas en futuras versiones. Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuPrincipal();
                    salir = true;
                    break;

            }
        }
    }

    //***************************************************************************************************************************** 
    //***************************************************************************************************************************** 
    //                                                  MENU VENDEDOR                                                            //
    //***************************************************************************************************************************** 
    //***************************************************************************************************************************** 


    static void MenuVendedor()
    {
        bool salir = false;
        int OpcionMenu;
        //UsuarioN UsuarioNNuevo = new UsuarioN();

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TP INTEGRAL CAI 2 - Menú Vendedor \n\n" +
                                "Elija la opción deseada: \n\n" +
                                "------ VENTAS ------ \n" +
                                "1 - Realizar Venta \n\n" +
                                "2 - Reporte de Ventas por Vendedor \n" +
                                "------------------------------ \n" +
                                "0 - Volver al menú principal \n");
            OpcionMenu = Utils.PedirEntre(0, 2, ""); // hasta que no ingresa un nro de 1 a 14, error

            switch (OpcionMenu)
            {
                case 0:
                    MenuPrincipal();
                    salir = true;
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Estas opciones estarán habilitadas en futuras versiones. Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuPrincipal();
                    salir = true;
                    break;

            }
        }
    }




}