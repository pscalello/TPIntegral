using Entidad;
using Negocio;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Presentacion // Note: actual namespace depends on the project name.HOLA
{
    internal class Menu
    {

        static void Main(string[] args)
        {
            UsuarioN UsuarioNuevo = new UsuarioN();

            // Hardcodeo de 3 usuarios: un Administrador, un supervisor y un vendedor

            //ADMINISTRADOR: Se instancia la entidad para que esté ACTIVO y con Pasword no genérica
            // Creación persistente de administrador
            UsuarioE Administrador = new UsuarioE("SOFIA", "GONZALEZ", "Rivadavia 333", "4444-5555", "admin@gmail.com", new DateTime(2023, 9, 1),
                                           new DateTime(2000, 6, 15), new DateTime(2023, 10, 1), "Administrador", 1, 40222888, "Admin1234");
            UsuarioN.Usuarios.Add(Administrador);


            //SUPERVISOR: Se usa método "CrearUsuario" de "NEGOCIO" para ponerlo inactivo y con clave genérica
            UsuarioNuevo.CrearUsuario("JUAN", "RAMIREZ", "Rivadavia 333", "8888-6666", "supervisor@gmail.com", new DateTime(2023, 1, 1),
                                       new DateTime(2005, 7, 15), "Supervisor", 2, 30252997);


            //VENDEDOR: Se usa método "CrearUsuario" de "NEGOCIO" para ponerlo inactivo y con clave genérica
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
        //                                       PANTALLAS LOGIN                                                                     //
        //*****************************************************************************************************************************


        static void PantallaLogin()
        {
            bool salir = false;
            int hostUsuario=0, intentos = 1;
            UsuarioN UsuarioNuevo = new UsuarioN();
            string NombreUsuario="", password="";

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("TP INTEGRAL CAI 2 - LOGIN \n");

                NombreUsuario = Utils.PedirPalabra("Ingrese su nombre de usuario:\n");
                password = Utils.PedirPalabra("Ingrese su password:\n");

                // valida Nombre Usuario y Password por negocio y recibe 1 si es admin, 2 si es supervisor, 3 si es vendedor,
                // 0 si no coincide pass y usuario y -1 si agotó intentos

                hostUsuario = UsuarioNuevo.AutenticarUsuario(NombreUsuario, password, intentos);

                if (hostUsuario == 0)
                {
                    Console.WriteLine("Nombre de Usuario o Password incorrecto. Inténtelo nuevamente.");
                    Console.ReadKey();
                    intentos += 1;
                }
                else
                {
                    salir = true;
                }
            }

            switch (hostUsuario)
            {
                    case -2:
                        Console.WriteLine("Por favor, cambie su contraseña. Presione una tecla para continuar");
                        Console.ReadKey();
                        salir = true;
                        CambioContraseña(NombreUsuario, password);
                        //Aca deberiamos agregar algo para que el -2 cambie y n vuelva
                        break;
                    case -1:
                        Console.WriteLine("Se agotaron sus intentos, comuníquese con un administrador. Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 1:
                        MenuAdministrador();
                        break;
                    case 2:
                        MenuSupervisor();
                        break;
                    case 3:
                        MenuVendedor();
                        break;
            }
        }


        //***************************************************************************************************************************** 
        //                                       PANTALLAS CAMBIO DE CONTRASEÑA                                                      //
        //*****************************************************************************************************************************


        static void CambioContraseña (string nombreUsuario, string password)
        {
            bool salir = false;
            string nuevoPassword;
            UsuarioN UsuarioNuevo = new UsuarioN();

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("TP INTEGRAL CAI 2 - CAMBIO DE CONTRASEÑA \n");


                nuevoPassword = Utils.PedirPalabra("Ingrese su nueva contraseña (De entre 8 y 15 carácteres, una mayúscula y un número,\n +" +
                                                    "distinta a la anterior y a la que recibió para el primer logueo.\n");

                if (UsuarioNuevo.CambioContraseña(nombreUsuario, nuevoPassword) == true)
                {
                    Console.WriteLine("Contraseña modificada con éxito! Presione cualquier tecla para volver a loguearse");
                    Console.ReadKey();
                    salir = true;
                }
                else
                {
                    Console.WriteLine("No puede usar esa contraseña, presione una tecla para volver a intentarlo.");
                    Console.ReadKey();
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

        //***************************************************************************************************************************** 
        //***************************************************************************************************************************** 
        //                                                  ABM USUARIOS                                                            //
        //*****************************************************************************************************************************
        //*****************************************************************************************************************************


        //***************************************************************************************************************************** 
        //                                                  ALTA USUARIOS                                                           //
        //*****************************************************************************************************************************


        static void AltaUsuarios()
        {
            bool salir = false;
            int OpcionMenu;
            //UsuarioN UsuarioNNuevo = new UsuarioN();

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("TP INTEGRAL CAI 2 - Alta de Usuarios \n\n");

                string nombre, apellido, direccion, usuario, telefono, email, nombreUsuario;
                DateTime fechaAlta, fechaNacimiento;
                int host, dni;
                UsuarioN UsuarioNuevo = new UsuarioN();
                bool creacionCorrecta;


                // 1) PEDIDO DE DATOS
                // Cada pedido hará una validación de integridad con la clase Utils

                nombre = Utils.PedirPalabra("Ingrese Nombre del Usuario:\n");
                apellido = Utils.PedirPalabra("Ingrese Apellido del Usuario:\n");
                direccion = Utils.PedirPalabra("Ingrese Direccion del Usuario:\n");
                telefono = Utils.PedirPalabra("Ingrese Teléfono del Usuario:\n");
                email = Utils.PedirEmail("Ingrese Email del Usuario:\n");

                // mínimo y máximo de fechas establecidos de acuerdo a criterio nuestro para integridad:
                // el alta no puede ser anterior a 1990 ni posterior a 2024 (suponiendo carga de futuros ingresos)
                // La fecha de nacimiento no puede ser anterior a 1930 ni posterior a 2010
                fechaAlta = Utils.PedirFechaEntre(new DateTime(1990, 1, 1), new DateTime(2024, 1, 1), "Ingrese la fecha de Alta (formato: YYYY-MM-DD):\n");
                fechaNacimiento = Utils.PedirFechaEntre(new DateTime(1930, 1, 1), new DateTime(2010, 1, 1), "Ingrese la fecha de Nacimiento (formato: YYYY-MM-DD):\n");

                nombreUsuario = Utils.PedirPalabra("Ingrese nombre de usuario:\n");
                while (UsuarioN.ValidarNombreUsuario(nombreUsuario, nombre, apellido) == false)
                {
                    nombreUsuario = Utils.PedirPalabra("El nombre de usuario ingresado ya existe o no cumple con las siguientes condiciones:" +
                        " debe de tener entre 8 y 15 caracteres y no puede contener ni el nombre ni el apellido del usuario. Ingrese un nuevo nombre de usuario:\n");
                }
                host = Utils.PedirEntre(1, 2, "Ingrese Perfil (1:Supervisor / 2: Vendedor):\n");
                dni = Utils.PedirEntre(1000000, 99999999, "Ingrese DNI:\n");



                // 2) CREACION DE USUARIO
                // Se llama al método de creación de la clase de negocio. Esta hará validaciones, devolviendo un boolean.
                // Si la validación es correcta, crea usuario y le permite al administrador seguir cargando o no.
                // Si es incorrecta, muestra error y se reinicia el ciclo

                creacionCorrecta = UsuarioNuevo.CrearUsuario(nombre, apellido, direccion, telefono, email, fechaAlta, fechaNacimiento, nombreUsuario, host, dni);


                if (creacionCorrecta == true)
                {
                    Console.WriteLine("\n\nUsuario creado con éxito!\n");
                    Console.WriteLine("Desea cargar otro usuario? (1:Si / 2:No)\n");
                    OpcionMenu = Utils.PedirEntre(1, 2, ""); // hasta que no ingresa un nro de 1 a 2, error

                    if (OpcionMenu == 2)
                    {
                        salir = true;
                    }

                }
                else
                {
                    Console.WriteLine("Error en los tipos de datos\n" +
                                      "Por favor, el usuario no cumple con las reglas de negocio o ya está en uso.\n " +
                                      "Presione una tecla para continuar.");
                    Console.ReadKey();
                }

            }
        }

        //***************************************************************************************************************************** 
        //                                                  CONSULTA USUARIOS                                                        //
        //*****************************************************************************************************************************

        static void ConsultaUsuarios()
        {
            List<UsuarioE> consultausuarios = new List<UsuarioE>();
            UsuarioN UsuarioNegocio = new UsuarioN();

            bool salir = false;
            int OpcionMenu, id = 0;
            //UsuarioN UsuarioNNuevo = new UsuarioN();
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("TP INTEGRAL CAI 2 - Consulta de Usuarios \n\n" +
                                    "Elija la opción deseada: \n\n" +
                                    "1 - Listar todos los usuarios \n" +
                                    "2 - Listar Administradores \n" +
                                    "3 - Listar Supervisores \n" +
                                    "4 - Listar Vendedores \n" +
                                    "5 - Listar Usuario por ID \n" +
                                    "0 - Volver al menú principal \n");
                OpcionMenu = Utils.PedirEntre(0, 5, ""); // hasta que no ingresa un nro de 0 a 5, error

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
                        consultausuarios = UsuarioNegocio.ConsultarUsuarios(OpcionMenu, new Guid(id, 0, 0, new byte[8])); //Solucion para pasar int como parámetro ID
                        break;
                    case 5:
                        id = Utils.PedirEntre(1, 99999, "Ingresar el ID deseado \n");
                        consultausuarios = UsuarioNegocio.ConsultarUsuarios(OpcionMenu, new Guid(id, 0, 0, new byte[8])); //Solucion para pasar int como parámetro ID
                        break;
                }

                if (consultausuarios.Count == 0)
                {
                    Console.WriteLine("No hay datos para mostrar.");
                }
                else
                {
                    foreach (UsuarioE usuario in consultausuarios)
                    {
                        Console.WriteLine($"ID: {usuario.Id}");
                        Console.WriteLine($"Nombre: {usuario.Nombre}");
                        Console.WriteLine($"Apellido: {usuario.Apellido}");
                        //// Agrega más propiedades según tu objeto UsuarioE
                        Console.WriteLine();
                    }
                }


                Console.WriteLine("\n\nFin del listado.\n");
                Console.WriteLine("Desea realizar otra consulta? (1:Si / 2:No)\n");
                OpcionMenu = Utils.PedirEntre(1, 2, ""); // hasta que no ingresa un nro de 1 a 2, error

                if (OpcionMenu == 2)
                {
                    salir = true;
                }

            }
        }


        //***************************************************************************************************************************** 
        //                    FIN - NO INSERTAR NADA DEBAJO DE ESTE COMENTARIO                                                       //
        //*****************************************************************************************************************************
    }
}

