DESAFÍO DE CODIFICACIÓN 

.NET Introducción 

Creará un video de grabación de pantalla completando el desafío, luego enviar un enlace al archivo a través de Google Drive o One Drive. 

Algunas cosas para considerar: 

- Le pedimos que complete este desafío dentro del plazo acordado en nuestra conversación. 

- NO DEBE editar el video, detenerlo y continuar más tarde, usar una segunda pantalla, copiar contenido de pantallas ocultas o cualquier cosa similar que pueda considerarse trampa. La grabación debe ser sin pausas y sin edición. ** 

- **DEBE mostrar el reloj del sistema operativo durante toda la grabación. 

Por favor, no maximice su pantalla de forma que el reloj de su sistema operativo quede oculto. Mantenlo siempre visible.

** - Puede usar un software de grabación de pantalla como Screenrec, QuickTime o algo similar para grabar el video. 

- La grabación debe ser de todo el desafío de codificación, de principio a fin, que dura aproximadamente 1 hora. 

- Cargue el archivo de video en Google Drive o One Drive y comparta un enlace abierto con nosotros (soportamos .mp4, archivos más pequeños/con menos de 4 gb). 

- A medida que complete el desafío, explique lo que está haciendo. Guíenos en su pensamiento, explique sus decisiones, etc. Muéstrenos su trabajo de interfaz de usuario, si corresponde. 

Empezando 

1. Instale Visual Studio y use el [SDK de dotnet 6]
2. Clone este Repositorio
3. Abra el archivo .sln en Visual Studio 2019 y comience

## Resumen Para este desafío de código, el candidato clonará y configurará una aplicación .NET MVC existente. La aplicación contendrá rutas, modelos y vistas mínimas, pero sin funcionalidad real creada. El candidato demostrará toda su experiencia en la creación de aplicaciones con el marco .NET y sus habilidades para resolver problemas. 

## Requisitos 

1.	Crear un nuevo método POST en el controlador FileController para iniciar la ejecucción de la lectura de archivo.

2.	Implementar acciones para leer el archivo Tickets.json compartido en el mismo repositorio al momento de ejecutar el llamado al método POST.

3.	Deserializar el archivo Tickets.json puede ser con la librería NewtonSoft o la de su preferencia.

4.	Con la información deserializada guardar toda la información en el modelo de Clases con los siguientes campos:
a)	IdTicket (Llave primaria, autonumérico)
b)	FechaCreación
c)	IdUsuario
d)	Estado

5.	Crear una nueva ruta en para mostrar la información básica de los tickets con las siguientes columnas, puede ser en HTML o en JSON como prefiera.

a)	Mes de creación de los tickets
b)	Id del Usuario que creo el ticket
c)	Número de Ticket estado 1
d)	Número de Ticket estado 2
e)	Número de Ticket cualquier estado
 
![image](https://user-images.githubusercontent.com/1902613/197829699-4ad40804-8998-448b-8119-28be141cb964.png)
