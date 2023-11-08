
# 1º PARCIAL LABORATORIO DE COMPUTACION - FACCINI TRINIDAD
# PROYECTO CRUD - VIVERO

## Sobre mi
Mi nombre es Trinidad Faccini, tengo 22 años. Soy de Villa La Angostura, Neuquén pero vivo actualmente en Buenos Aires porque me encuentro estudiando la carrera de Tecnicatura Universitaria en Programacion en la UTN de Avellanda. Anteriormente estudié dos años en DigitalHouse, donde obtuve un diploma como Certified Tech Developer, orientandome mas en lo que es el desarrollo Front-End.

## Resumen  

Esta aplicación simula el sistema de manejo de una red de viveros.  
Al iniciarse, se le pedirá a la persona que ingrese su correo y clave y en caso de ser correctos se continuará a elegir el archivo con la información de las plantas del vivero con el que se quiere trabajar.  

Una vez elegido, se podrá visualizar una lista CON LOS DATOS MAS RELEVANTES (no todos) de las plantas que se encuentran en ese vivero, pudiendo esta ser ordenada según nombre de la planta, precio o altura máxima que la planta puede alcanzar.  

Si se desea ver mas detalles de alguna planta, solo debe seleccionarla en la lista y luego cliquear el botón "DETALLES DE LA PLANTA SELECCIONADA".

En el caso que se desee modificar alguna planta de la lista, se la debe seleccionar y luego cliquear el botón "MODIFICAR PLANTA SELECCIONADA". Si se desea eliminarla cliquear el boton "ELIMINAR PLANTA SELECCIONADA". 

Si el usuario desea regar la planta, solo debe seleccionar la planta a regar y luego cliquear el botón "REGAR PLANTA SELECCIONADA". Se le informará tanto si pudo ser regada como si no y la altura actual de la planta. 

Por otro lado, si el usuario desea agregar otra planta al vivero, solamente debe apretar alguno de los botones para AGREGAR plantas (puede ser Cactus, Arbol o Flor) y completar el formulario.  

Una vez completo debe cliquear aceptar. Este se validara y si todos los datos estaban correctos, se intentará agregar la planta a la lista. 
Si no habia un ejemplar igual anteriormente en el vivero, este se agregará a la lista de plantas, si no se mostrará un mensaje. 

Al momento de cerrar la aplicación se le pedirá al usuario que elija el archivo donde quiere guardar la lista de plantas.  

ATENCION: Solo los usuarios de tipo administrador o supervisor podran modificar o eliminar plantas.  

## Diagrama de clases
A continuación se adjuntan los diagramas de clases que incluyen todas las clases utilizadas en esta solución. Tambien incluyen los enumerados creados. 

<img width="728" alt="image" src="https://github.com/trinifaccini/Faccini.Trinidad.PrimerParcial/blob/master/Diagramas/DiagramaClasesProyectoVivero.png">
<img width="728" alt="image" src="https://github.com/trinifaccini/Faccini.Trinidad.PrimerParcial/blob/master/Diagramas/DiagramaClasesFormularios.png">
<img width="728" alt="image" src = "https://github.com/trinifaccini/Faccini.Trinidad.PrimerParcial/blob/master/Diagramas/DiagramaClasesUtilidades.png">
