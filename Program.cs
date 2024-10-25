using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte24Oct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Soporte de Hardware y Software - Sergio Steven Parra Cuesta");
            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
            Console.WriteLine("1. La computadora no enciende");
            Console.WriteLine("2. La pantalla se queda en negro");
            Console.WriteLine("3. La computadora se congela o se vuelve muy lenta");
            Console.WriteLine("4. Me aparecen mensajes de error");
            Console.WriteLine("5. No se pueden conectar dispositivos a la computadora");
            Console.WriteLine("6. No arranca el sistema operativo");
            Console.WriteLine("7. Ruidos extraños en el hardware del computador");
            Console.WriteLine("8. Errores en programas");
            var desc = Console.ReadLine();
            switch (desc)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("La computadora no enciende");
                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                    Console.WriteLine("¿La computadora está conectada a la corriente?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    var desc1 = Console.ReadLine();
                    if (desc1 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("La computadora no enciende");
                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                        Console.WriteLine("¿El interruptor de la fuente de alimentación está encendido?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        var desc2 = Console.ReadLine();
                        if (desc2 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("La computadora no enciende");
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("¿El cable de alimentación está en buen estado?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            var desc3 = Console.ReadLine();
                            if (desc3 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("La computadora no enciende");
                                Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                Console.WriteLine("¿Escuchas algún sonido (ventiladores, pitidos)?");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                var desc4 = Console.ReadLine();
                                if (desc4 == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("La computadora no enciende");
                                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                    Console.WriteLine("¿La pantalla está encendida y recibe señal?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    var desc5 = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                    if (desc5 == "1")
                                    {
                                        Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                        Console.WriteLine("Puede ser un problema con el sistema operativo; intenta reiniciar en modo seguro");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Podría haber un fallo en la placa base o en la fuente de alimentación; busca asistencia técnica");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Verifica las conexiones de la pantalla y prueba con otro cable o monitor");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Puede haber un problema de hardware; busca asistencia técnica");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enciéndelo y prueba nuevamente");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conéctala y prueba encenderla nuevamente");
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    Console.Clear();
                    string problema = "La pantalla se queda en negro";
                    Console.WriteLine(problema);
                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                    Console.WriteLine("¿La computadora está conectada a la corriente?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    desc1 = Console.ReadLine();
                    if (desc1 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine(problema);
                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                        Console.WriteLine("¿La pantalla está encendida?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        var desc2 = Console.ReadLine();
                        if (desc2 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine(problema);
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("¿El brillo de la pantalla está ajustado correctamente?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            var desc3 = Console.ReadLine();
                            if (desc3 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(problema);
                                Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                Console.WriteLine("¿Escuchas algún sonido (ventiladores, pitidos) de la computadora?");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                var desc4 = Console.ReadLine();
                                if (desc4 == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine(problema);
                                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                    Console.WriteLine("¿Tienes otro monitor disponible?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    var desc5 = Console.ReadLine();
                                    if (desc5 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine(problema);
                                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                        Console.WriteLine("Conéctalo y verifica si muestra imagen");
                                        Console.WriteLine("1. Si");
                                        Console.WriteLine("2. No");
                                        var desc6 = Console.ReadLine();
                                        if (desc6 == "1")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                            Console.WriteLine("El problema puede estar en la pantalla original.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine(problema);
                                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                            Console.WriteLine("¿La tarjeta gráfica está bien instalada?");
                                            Console.WriteLine("1. Si");
                                            Console.WriteLine("2. No");
                                            var desc7 = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                            if (desc7 == "1")
                                            {
                                                Console.WriteLine("Puede ser un problema de software o del sistema operativo; intenta reiniciar en modo seguro");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Reinstala la tarjeta gráfica y prueba nuevamente.");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(problema);
                                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                        Console.WriteLine("¿La tarjeta gráfica está bien instalada?");
                                        Console.WriteLine("1. Si");
                                        Console.WriteLine("2. No");
                                        var desc7 = Console.ReadLine();
                                        if (desc7 == "1")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                            Console.WriteLine("Puede ser un problema de software o del sistema operativo; intenta reiniciar en modo seguro");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Reinstala la tarjeta gráfica y prueba nuevamente.");
                                            Console.ReadKey();

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Puede haber un problema de hardware, busca asistencia técnica");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ajusta el brillo y prueba nuevamente");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Verifica el cable de alimentación y enciéndela");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conéctala y prueba encenderla nuevamente");
                        Console.ReadKey();
                    }
                    break;
                case "3":
                    Console.Clear();
                    problema = "La computadora se congela o se vuelve muy lenta";
                    Console.WriteLine(problema);
                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                    Console.WriteLine("Prueba reiniciar la computadora, se solucionó el problema?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    desc1 = Console.ReadLine();
                    if (desc1 == "2")
                    {
                        Console.Clear();
                        Console.WriteLine(problema);
                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                        Console.WriteLine("¿Es el rendimiento lento constante o intermitente?");
                        Console.WriteLine("1. Constante");
                        Console.WriteLine("2. Intermitente");
                        var desc2 = Console.ReadLine();
                        if (desc2 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine(problema);
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("Verifica si hay programas en segundo plano consumiendo recursos. Cierra programas innecesarios. ¿Se soluciona el problema?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            var desc3 = Console.ReadLine();
                            if (desc3 == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(problema);
                                Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                Console.WriteLine("¿Hay suficiente espacio en el disco duro?");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                var desc4 = Console.ReadLine();
                                if (desc4 == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine(problema);
                                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                    Console.WriteLine("¿El hardware está funcionando correctamente?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    var desc5 = Console.ReadLine();
                                    if (desc5 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine(problema);
                                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                        Console.WriteLine("¿Hay malware o virus en la computadora?");
                                        Console.WriteLine("1. Si");
                                        Console.WriteLine("2. No");
                                        var desc6 = Console.ReadLine();
                                        if (desc6 == "2")
                                        {
                                            Console.Clear();
                                            Console.WriteLine(problema);
                                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                            Console.WriteLine("¿Has considerado actualizar el hardware (RAM, disco duro, etc.)?");
                                            Console.WriteLine("1. Si");
                                            Console.WriteLine("2. No");
                                            var desc7 = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                            if (desc7 == "1")
                                            {
                                                Console.WriteLine("Realizar la actualización");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Considera la opción de actualizar si el problema persiste.");
                                                Console.ReadKey();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ejecuta un análisis con software antivirus y elimina amenazas");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Verifica cabls y conexiones. Si el problema persiste, considera la posibilidad de que necesites reparar o reemplazar hardware.");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(problema);
                                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                    Console.WriteLine("Libera espacio eliminando archivos o programas innecesarios, se resuelve el problema?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    var desc21 = Console.ReadLine();
                                    if (desc21 == "1")
                                    {
                                        Console.WriteLine("Problema solucinado");
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Problema solucionado");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(problema);
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("Revisa la conexión a internet (si aplica). ¿Hay actualizaciones pendientes del sistema operativo o programas?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            var desc21 = Console.ReadLine();
                            if (desc21 == "1")
                            {
                                Console.WriteLine("Actualiza y reinicia");
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Problema solucionado");
                        Console.ReadKey();
                    }
                    break;
                case "4":
                    Console.Clear();
                    problema = "Me aparecen mensajes de error";
                    Console.WriteLine(problema);
                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                    Console.WriteLine("¿Qué tipo de mensaje de error aparece?");
                    Console.WriteLine("1. Error del sistema operativo");
                    Console.WriteLine("2. Error de aplicación");
                    desc1 = Console.ReadLine();
                    switch (desc1)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(problema);
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("Reinicia la computadora. ¿El mensaje persiste?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            var desc2 = Console.ReadLine();
                            if (desc2 == "1")
                                goto case "3";
                            else
                                Console.WriteLine("Problema resuelto");
                                break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine(problema);
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("Cierra la aplicación y vuelve a abrirla. ¿El mensaje persiste?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            desc2 = Console.ReadLine();
                            if (desc2 == "1")
                                goto case "3";
                            else
                                Console.WriteLine("Problema resuelto");
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine(problema);
                            Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                            Console.WriteLine("¿Has instalado recientemente algún software o actualización?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            var desc3 = Console.ReadLine();
                            if (desc3 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(problema);
                                Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                Console.WriteLine("Desinstala la última instalación o actualización. ¿El mensaje persiste?");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                var desc4 = Console.ReadLine();
                                if (desc4 == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine(problema);
                                    Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                    Console.WriteLine("¿Hay problemas de hardware que podrían causar el error?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    var desc5 = Console.ReadLine();
                                    if (desc5 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine(problema);
                                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                                        Console.WriteLine("Verifica conexiones y componentes (RAM, disco duro, etc.). ¿El mensaje persiste?");
                                        Console.WriteLine("1. Si");
                                        Console.WriteLine("2. No");
                                        var desc6 = Console.ReadLine();
                                        if (desc6 == "1")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("La causa mas probable de la falla puede ser: ");
                                            Console.WriteLine("El problema puede estar en la pantalla original.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            
                                        }
                                    }
                                    else
                                    {
                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Puede haber un problema de hardware, busca asistencia técnica");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                
                            }
                            break;
                    }
                        


                    if (desc1 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine(problema);
                        Console.WriteLine("Seleccione su caso, por favor ingrese un número: ");
                        Console.WriteLine("¿La pantalla está encendida?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        var desc2 = Console.ReadLine();
                        if (desc2 == "1")
                        {




                            
                        }
                        else
                        {
                            Console.WriteLine("Verifica el cable de alimentación y enciéndela");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conéctala y prueba encenderla nuevamente");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
