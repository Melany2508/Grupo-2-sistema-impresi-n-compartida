# ColaCircularGrupo2

## Proyecto 02 · Sistema de impresión compartida

Aplicación de escritorio desarrollada en **C# con Windows Forms**. Simula una impresora compartida que recibe documentos y los atiende en el orden en que fueron agregados.

---

## Integrantes · Grupo 2

- **Bradly Gustavo Viquez Diaz**
- **Alfaro Duarte Melany Josuame**
- **Hernandez Hernandez Yeudy Unier**
- **Quiros Sarmiento Geicol Joseph**
- **Mena De La O Luis Antonio**

---

## ¿Qué es una cola circular?

Una cola sigue la regla **FIFO** (*First In, First Out*): el primer documento que entra es el primero que se imprime. En una cola circular, los documentos se guardan en un arreglo de tamaño fijo. Cuando un índice llega al final del arreglo, vuelve al inicio mediante el operador módulo (`%`). Así se aprovechan las posiciones que quedaron libres, sin desplazar ni reconstruir los documentos pendientes.

La aplicación utiliza un arreglo de **5 posiciones** y mantiene estos datos:

| Dato | Función |
|---|---|
| `frente` | Índice del documento que se imprimirá a continuación. |
| `siguienteInsercion` | Índice donde se guardará el próximo documento. |
| `cantidad` | Número de documentos pendientes; permite distinguir la cola vacía de la llena. |

### Operaciones principales

- **Agregar:** si la cola no está llena, guarda el documento en `siguienteInsercion`, avanza ese índice con `(siguienteInsercion + 1) % 5` y aumenta `cantidad`.
- **Imprimir:** si hay documentos, retira el que está en `frente`, libera esa casilla, avanza `frente` con `(frente + 1) % 5` y disminuye `cantidad`.
- **Cola vacía:** `cantidad == 0`.
- **Cola llena:** `cantidad == 5`.

Cada operación trabaja con índices circulares. Los documentos restantes se mantienen en sus posiciones físicas.

---

## Prueba obligatoria

Pulsa **Cargar prueba A–G** en la aplicación. El botón realiza estas operaciones:

1. Agrega `A`, `B`, `C`, `D` y `E`.
2. Imprime `A` y `B`, liberando las posiciones 0 y 1.
3. Agrega `F` y `G`, reutilizando las posiciones 0 y 1.

| Momento | Arreglo físico (índices 0 a 4) | Frente | Siguiente inserción | Pendientes |
|---|---|---:|---:|---:|
| Después de agregar A–E | `[A, B, C, D, E]` | 0 | 0 | 5 |
| Después de imprimir A y B | `[—, —, C, D, E]` | 2 | 0 | 3 |
| Después de agregar F y G | `[F, G, C, D, E]` | 2 | 2 | 5 |

Al final, el **arreglo físico** es `[F, G, C, D, E]`, pero la cola empieza en el índice 2. Por eso, el **orden de impresión** es `C → D → E → F → G`.

---

## Cómo abrir en Visual Studio

1. Abre `ColaCircularGrupo2.csproj` en Visual Studio 2022 con el SDK de **.NET 10** y la carga de trabajo **Desarrollo de escritorio de .NET**.
2. Abre `FormPrincipal.cs` y selecciona **Diseño** para editar los controles visualmente. El diseño y los controles están en `FormPrincipal.Designer.cs`; la lógica de eventos permanece en `FormPrincipal.cs`.
3. Ejecuta el proyecto con **F5**.
4. Para probar manualmente, escribe un nombre de documento y selecciona **Agregar a la cola**. Usa **Imprimir siguiente** para retirar el documento más antiguo.
5. Usa **Cargar prueba A–G** para repetir la prueba obligatoria.
6. Pulsa **Salir** para cerrar la aplicación.

La ventana muestra las cinco posiciones físicas, el orden lógico de impresión, el frente y la siguiente posición de inserción. También informa cuando la cola está llena o vacía.
