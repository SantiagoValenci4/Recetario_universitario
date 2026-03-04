// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var universidades = new List<Universidad>();

universidades.Add(new Universidad() { Id = 1, Nombre = "ITM", Ciudad = "Medellín", Pais = "Colombia", FechaRegistro = DateTime.Now });
universidades.Add(new Universidad() { Id = 2, Nombre = "UdeA", Ciudad = "Medellín", Pais = "Colombia", FechaRegistro = DateTime.Now });
universidades.Add(new Universidad() { Id = 3, Nombre = "Nacional", Ciudad = "Bogotá", Pais = "Colombia", FechaRegistro = DateTime.Now });
universidades.Add(new Universidad() { Id = 4, Nombre = "EAFIT", Ciudad = "Medellín", Pais = "Colombia", FechaRegistro = DateTime.Now });
universidades.Add(new Universidad() { Id = 5, Nombre = "Javeriana", Ciudad = "Cali", Pais = "Colombia", FechaRegistro = DateTime.Now });

var usuarios = new List<Usuarios>();

usuarios.Add(new Usuarios() { Id = 1, Nombre = "Juan", IdUniversidad = 1, Numero = "3001111111", Correo = "juan@gmail.com", FechaNacimiento = new DateTime(2000, 1, 1), Activo = true });
usuarios.Add(new Usuarios() { Id = 2, Nombre = "Ana", IdUniversidad = 2, Numero = "3002222222", Correo = "ana@gmail.com", FechaNacimiento = new DateTime(1999, 5, 10), Activo = true });
usuarios.Add(new Usuarios() { Id = 3, Nombre = "Luis", IdUniversidad = 3, Numero = "3003333333", Correo = "luis@gmail.com", FechaNacimiento = new DateTime(2001, 3, 20), Activo = true });
usuarios.Add(new Usuarios() { Id = 4, Nombre = "Sofia", IdUniversidad = 4, Numero = "3004444444", Correo = "sofia@gmail.com", FechaNacimiento = new DateTime(1998, 7, 15), Activo = true });
usuarios.Add(new Usuarios() { Id = 5, Nombre = "Carlos", IdUniversidad = 1, Numero = "3005555555", Correo = "carlos@gmail.com", FechaNacimiento = new DateTime(2002, 11, 2), Activo = false });

var recetas = new List<Recetas>();

recetas.Add(new Recetas() { Id = 1, Nombre = "Arroz con huevo", Descripcion = "Fácil y rápido", Foto = "img1.jpg", IdCategoria = 1, IdUsuario = 1, FechaCreacion = DateTime.Now });
recetas.Add(new Recetas() { Id = 2, Nombre = "Pasta", Descripcion = "Clásica", Foto = "img2.jpg", IdCategoria = 2, IdUsuario = 2, FechaCreacion = DateTime.Now });
recetas.Add(new Recetas() { Id = 3, Nombre = "Ensalada", Descripcion = "Saludable", Foto = "img3.jpg", IdCategoria = 3, IdUsuario = 3, FechaCreacion = DateTime.Now });
recetas.Add(new Recetas() { Id = 4, Nombre = "Brownie", Descripcion = "Postre", Foto = "img4.jpg", IdCategoria = 4, IdUsuario = 4, FechaCreacion = DateTime.Now });
recetas.Add(new Recetas() { Id = 5, Nombre = "Sushi", Descripcion = "Avanzado", Foto = "img5.jpg", IdCategoria = 5, IdUsuario = 5, FechaCreacion = DateTime.Now });

var categorias = new List<Categorias>();

categorias.Add(new Categorias() { Id = 1, Nombre = "Rápida", Descripcion = "Menos de 30 min", Tipo = "Tiempo", Activa = true });
categorias.Add(new Categorias() { Id = 2, Nombre = "Económica", Descripcion = "Bajo costo", Tipo = "Costo", Activa = true });
categorias.Add(new Categorias() { Id = 3, Nombre = "Saludable", Descripcion = "Bajas calorías", Tipo = "Salud", Activa = true });
categorias.Add(new Categorias() { Id = 4, Nombre = "Postres", Descripcion = "Dulces", Tipo = "Comida", Activa = true });
categorias.Add(new Categorias() { Id = 5, Nombre = "Gourmet", Descripcion = "Alta cocina", Tipo = "Nivel", Activa = true });


var ingredientes = new List<Ingredientes>();

ingredientes.Add(new Ingredientes() { Id = 1, Nombre = "Arroz", Estado = "Seco", PrecioPromedio = 2000, Activo = true });
ingredientes.Add(new Ingredientes() { Id = 2, Nombre = "Huevo", Estado = "Fresco", PrecioPromedio = 500, Activo = true });
ingredientes.Add(new Ingredientes() { Id = 3, Nombre = "Pasta", Estado = "Seco", PrecioPromedio = 3000, Activo = true });
ingredientes.Add(new Ingredientes() { Id = 4, Nombre = "Lechuga", Estado = "Fresco", PrecioPromedio = 1500, Activo = true });
ingredientes.Add(new Ingredientes() { Id = 5, Nombre = "Chocolate", Estado = "Procesado", PrecioPromedio = 4000, Activo = true });


var recetaIngredientes = new List<RecetaIngrediente>();

recetaIngredientes.Add(new RecetaIngrediente() { Id = 1, IdReceta = 1, IdIngrediente = 1, Cantidad = 1, Unidad = "taza", Opcional = false });
recetaIngredientes.Add(new RecetaIngrediente() { Id = 2, IdReceta = 1, IdIngrediente = 2, Cantidad = 2, Unidad = "unidad", Opcional = false });
recetaIngredientes.Add(new RecetaIngrediente() { Id = 3, IdReceta = 2, IdIngrediente = 3, Cantidad = 1, Unidad = "paquete", Opcional = false });
recetaIngredientes.Add(new RecetaIngrediente() { Id = 4, IdReceta = 3, IdIngrediente = 4, Cantidad = 1, Unidad = "unidad", Opcional = false });
recetaIngredientes.Add(new RecetaIngrediente() { Id = 5, IdReceta = 4, IdIngrediente = 5, Cantidad = 2, Unidad = "barra", Opcional = false });


var favoritos = new List<Favoritos>();

favoritos.Add(new Favoritos() { Id = 1, IdUsuario = 1, IdReceta = 1, FechaAgregado = DateTime.Now, Activo = true });
favoritos.Add(new Favoritos() { Id = 2, IdUsuario = 2, IdReceta = 2, FechaAgregado = DateTime.Now, Activo = true });
favoritos.Add(new Favoritos() { Id = 3, IdUsuario = 3, IdReceta = 3, FechaAgregado = DateTime.Now, Activo = true });
favoritos.Add(new Favoritos() { Id = 4, IdUsuario = 4, IdReceta = 1, FechaAgregado = DateTime.Now, Activo = true });
favoritos.Add(new Favoritos() { Id = 5, IdUsuario = 5, IdReceta = 2, FechaAgregado = DateTime.Now, Activo = false });


var preparaciones = new List<Preparacion>();

preparaciones.Add(new Preparacion() { Id = 1, IdReceta = 1, NumeroPaso = 1, Descripcion = "Hervir agua", TiempoEstimado = 10 });
preparaciones.Add(new Preparacion() { Id = 2, IdReceta = 1, NumeroPaso = 2, Descripcion = "Agregar arroz", TiempoEstimado = 15 });
preparaciones.Add(new Preparacion() { Id = 3, IdReceta = 2, NumeroPaso = 1, Descripcion = "Cocinar pasta", TiempoEstimado = 12 });
preparaciones.Add(new Preparacion() { Id = 4, IdReceta = 3, NumeroPaso = 1, Descripcion = "Lavar vegetales", TiempoEstimado = 5 });
preparaciones.Add(new Preparacion() { Id = 5, IdReceta = 4, NumeroPaso = 1, Descripcion = "Derretir chocolate", TiempoEstimado = 8 });


var resenas = new List<Reseñas>();

resenas.Add(new Reseñas() { Id = 1, IdUsuario = 1, IdReceta = 1, Comentario = "Muy buena", Nota = 5, FechaComentario = DateTime.Now });
resenas.Add(new Reseñas() { Id = 2, IdUsuario = 2, IdReceta = 2, Comentario = "Fácil", Nota = 4, FechaComentario = DateTime.Now });
resenas.Add(new Reseñas() { Id = 3, IdUsuario = 3, IdReceta = 3, Comentario = "Saludable", Nota = 5, FechaComentario = DateTime.Now });
resenas.Add(new Reseñas() { Id = 4, IdUsuario = 4, IdReceta = 4, Comentario = "Delicioso", Nota = 5, FechaComentario = DateTime.Now });
resenas.Add(new Reseñas() { Id = 5, IdUsuario = 5, IdReceta = 5, Comentario = "Difícil", Nota = 3, FechaComentario = DateTime.Now });


var novedades = new List<TablaNovedades>();

novedades.Add(new TablaNovedades() { Id = 1, Nombre = "Nueva receta", Descripcion = "Arroz especial", FechaNovedad = DateTime.Now, IdReceta = 1, Activa = true });
novedades.Add(new TablaNovedades() { Id = 2, Nombre = "Trending", Descripcion = "Pasta popular", FechaNovedad = DateTime.Now, IdReceta = 2, Activa = true });
novedades.Add(new TablaNovedades() { Id = 3, Nombre = "Salud", Descripcion = "Ensalada fit", FechaNovedad = DateTime.Now, IdReceta = 3, Activa = true });
novedades.Add(new TablaNovedades() { Id = 4, Nombre = "Postre", Descripcion = "Brownie top", FechaNovedad = DateTime.Now, IdReceta = 4, Activa = true });
novedades.Add(new TablaNovedades() { Id = 5, Nombre = "Premium", Descripcion = "Sushi chef", FechaNovedad = DateTime.Now, IdReceta = 5, Activa = false });


var utensilios = new List<Utensilios>();

utensilios.Add(new Utensilios() { Id = 1, Nombre = "Olla", Material = "Aluminio", Tamano = "Grande", Disponible = true });
utensilios.Add(new Utensilios() { Id = 2, Nombre = "Sartén", Material = "Acero", Tamano = "Mediano", Disponible = true });
utensilios.Add(new Utensilios() { Id = 3, Nombre = "Cuchillo", Material = "Acero", Tamano = "Pequeño", Disponible = true });
utensilios.Add(new Utensilios() { Id = 4, Nombre = "Licuadora", Material = "Plástico", Tamano = "Grande", Disponible = false });
utensilios.Add(new Utensilios() { Id = 5, Nombre = "Espátula", Material = "Silicona", Tamano = "Pequeño", Disponible = true });


var tips = new List<Tips>();

tips.Add(new Tips() { Id = 1, Mejora = "Menos sal", Recomendacion = "Usar poca sal", IdReceta = 1, Fecha = DateTime.Now });
tips.Add(new Tips() { Id = 2, Mejora = "Más sabor", Recomendacion = "Agregar especias", IdReceta = 2, Fecha = DateTime.Now });
tips.Add(new Tips() { Id = 3, Mejora = "Más saludable", Recomendacion = "Usar aceite de oliva", IdReceta = 3, Fecha = DateTime.Now });
tips.Add(new Tips() { Id = 4, Mejora = "Mejor textura", Recomendacion = "No sobrecocinar", IdReceta = 4, Fecha = DateTime.Now });
tips.Add(new Tips() { Id = 5, Mejora = "Presentación", Recomendacion = "Decorar bien", IdReceta = 5, Fecha = DateTime.Now });


var diccionario = new List<Diccionario>();

diccionario.Add(new Diccionario() { Id = 1, Palabra = "Hervir", Significado = "Cocinar en agua caliente" });
diccionario.Add(new Diccionario() { Id = 2, Palabra = "Freír", Significado = "Cocinar en aceite" });
diccionario.Add(new Diccionario() { Id = 3, Palabra = "Asar", Significado = "Cocinar al fuego" });
diccionario.Add(new Diccionario() { Id = 4, Palabra = "Licuar", Significado = "Mezclar alimentos" });
diccionario.Add(new Diccionario() { Id = 5, Palabra = "Hornear", Significado = "Cocinar en horno" });


var historial = new List<Historial>();

historial.Add(new Historial() { Id = 1, IdUsuario = 1, IdReceta = 1, FechaVisualizacion = DateTime.Now, TiempoVisualizacion = 5 });
historial.Add(new Historial() { Id = 2, IdUsuario = 2, IdReceta = 2, FechaVisualizacion = DateTime.Now, TiempoVisualizacion = 10 });
historial.Add(new Historial() { Id = 3, IdUsuario = 3, IdReceta = 3, FechaVisualizacion = DateTime.Now, TiempoVisualizacion = 7 });
historial.Add(new Historial() { Id = 4, IdUsuario = 4, IdReceta = 4, FechaVisualizacion = DateTime.Now, TiempoVisualizacion = 12 });
historial.Add(new Historial() { Id = 5, IdUsuario = 5, IdReceta = 5, FechaVisualizacion = DateTime.Now, TiempoVisualizacion = 3 });


var planes = new List<PlanSemanal>();

planes.Add(new PlanSemanal() { Id = 1, IdUsuario = 1, FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 3, 7), Presupuesto = 50000 });
planes.Add(new PlanSemanal() { Id = 2, IdUsuario = 2, FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 3, 7), Presupuesto = 60000 });
planes.Add(new PlanSemanal() { Id = 3, IdUsuario = 3, FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 3, 7), Presupuesto = 45000 });
planes.Add(new PlanSemanal() { Id = 4, IdUsuario = 4, FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 3, 7), Presupuesto = 70000 });
planes.Add(new PlanSemanal() { Id = 5, IdUsuario = 5, FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 3, 7), Presupuesto = 55000 });


var soportes = new List<Soporte>();

soportes.Add(new Soporte() { Id = 1, IdUsuario = 1, Asunto = "Error receta", Descripcion = "No carga imagen", FechaCreacion = DateTime.Now, Estado = "Abierto" });
soportes.Add(new Soporte() { Id = 2, IdUsuario = 2, Asunto = "Login", Descripcion = "No puedo entrar", FechaCreacion = DateTime.Now, Estado = "Cerrado" });
soportes.Add(new Soporte() { Id = 3, IdUsuario = 3, Asunto = "Bug", Descripcion = "Falla al guardar", FechaCreacion = DateTime.Now, Estado = "Abierto" });
soportes.Add(new Soporte() { Id = 4, IdUsuario = 4, Asunto = "Consulta", Descripcion = "Duda con recetas", FechaCreacion = DateTime.Now, Estado = "Cerrado" });
soportes.Add(new Soporte() { Id = 5, IdUsuario = 5, Asunto = "Cuenta", Descripcion = "Cambiar correo", FechaCreacion = DateTime.Now, Estado = "Abierto" });


var seguimientos = new List<Seguimiento>();

seguimientos.Add(new Seguimiento() { Id = 1, IdSoporte = 1, Comentario = "En revisión", Fecha = DateTime.Now, Estado = "Pendiente" });
seguimientos.Add(new Seguimiento() { Id = 2, IdSoporte = 2, Comentario = "Resuelto", Fecha = DateTime.Now, Estado = "Cerrado" });
seguimientos.Add(new Seguimiento() { Id = 3, IdSoporte = 3, Comentario = "Escalado", Fecha = DateTime.Now, Estado = "Proceso" });
seguimientos.Add(new Seguimiento() { Id = 4, IdSoporte = 4, Comentario = "Respondido", Fecha = DateTime.Now, Estado = "Cerrado" });
seguimientos.Add(new Seguimiento() { Id = 5, IdSoporte = 5, Comentario = "En espera", Fecha = DateTime.Now, Estado = "Pendiente" });


var notificaciones = new List<Notificaciones>();

notificaciones.Add(new Notificaciones() { Id = 1, IdUsuario = 1, Mensaje = "Nueva receta disponible", Fecha = DateTime.Now, Leida = false });
notificaciones.Add(new Notificaciones() { Id = 2, IdUsuario = 2, Mensaje = "Tu receta fue aprobada", Fecha = DateTime.Now, Leida = true });
notificaciones.Add(new Notificaciones() { Id = 3, IdUsuario = 3, Mensaje = "Nuevo comentario", Fecha = DateTime.Now, Leida = false });
notificaciones.Add(new Notificaciones() { Id = 4, IdUsuario = 4, Mensaje = "Actualización del sistema", Fecha = DateTime.Now, Leida = true });
notificaciones.Add(new Notificaciones() { Id = 5, IdUsuario = 5, Mensaje = "Receta recomendada", Fecha = DateTime.Now, Leida = false });


var preguntas = new List<Preguntas>();

preguntas.Add(new Preguntas() { Id = 1, Pregunta = "¿Cómo hervir agua?", Respuesta = "Colocar agua a fuego alto hasta ebullición" });
preguntas.Add(new Preguntas() { Id = 2, Pregunta = "¿Cómo hacer arroz?", Respuesta = "Cocinar arroz con agua y sal" });
preguntas.Add(new Preguntas() { Id = 3, Pregunta = "¿Qué es freír?", Respuesta = "Cocinar en aceite caliente" });
preguntas.Add(new Preguntas() { Id = 4, Pregunta = "¿Cómo hacer pasta?", Respuesta = "Hervir en agua con sal" });
preguntas.Add(new Preguntas() { Id = 5, Pregunta = "¿Qué es hornear?", Respuesta = "Cocinar en horno a temperatura controlada" });


var moderadores = new List<Moderador>();

moderadores.Add(new Moderador() { Id = 1, IdUsuario = 1, AreaAsignacion = "Recetas" });
moderadores.Add(new Moderador() { Id = 2, IdUsuario = 2, AreaAsignacion = "Comentarios" });
moderadores.Add(new Moderador() { Id = 3, IdUsuario = 3, AreaAsignacion = "Usuarios" });
moderadores.Add(new Moderador() { Id = 4, IdUsuario = 4, AreaAsignacion = "Soporte" });
moderadores.Add(new Moderador() { Id = 5, IdUsuario = 5, AreaAsignacion = "General" });




// 1
public class Usuarios
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int IdUniversidad { get; set; }
    public string Numero { get; set; }
    public string Correo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Activo { get; set; }

    
    public Universidad? _Universidad { get; set; }
    public List<Recetas>? Recetas { get; set; }
    public List<Reseñas>? Reseñas { get; set; }
    public List<Favoritos>? Favoritos { get; set; }
    public List<Historial>? Historial { get; set; }
    public List<PlanSemanal>? Planes { get; set; }
    public List<Soporte>? Soportes { get; set; }
    public List<Notificaciones>? Notificaciones { get; set; }
}

// 2
public class Universidad
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Ciudad { get; set; }
    public string Pais { get; set; }
    public DateTime FechaRegistro { get; set; }

 
    public List<Usuarios>? Usuarios { get; set; }
}



// 3
public class Moderador
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string AreaAsignacion { get; set; }

    
    public Usuarios? _Usuario { get; set; }
}

// 4
public class Recetas
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Foto { get; set; }
    public int IdCategoria { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaCreacion { get; set; }

    
    public Categorias? _Categoria { get; set; }
    public Usuarios?  _Usuario { get; set; }

    public List<RecetaIngrediente>? RecetaIngredientes { get; set; }
    public List<Preparacion>? Preparaciones { get; set; }
    public List<Reseñas>? Reseñas { get; set; }
    public List<Favoritos>? Favoritos { get; set; }
    public List<Tips>? Tips { get; set; }
    public List<Historial>? Historial { get; set; }
    public List<TablaNovedades>? Novedades { get; set; }
}

// 5
public class Categorias
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Tipo { get; set; }
    public bool Activa { get; set; }

    
    public List<Recetas>? Recetas { get; set; }
}

// 6
public class Ingredientes
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Estado { get; set; }
    public decimal PrecioPromedio { get; set; }
    public bool Activo { get; set; }

    
    public List<RecetaIngrediente>? RecetaIngredientes { get; set; }
}

// 7
public class RecetaIngrediente
{
    public int Id { get; set; }
    public int IdReceta { get; set; }
    public int IdIngrediente { get; set; }
    public decimal Cantidad { get; set; }
    public string Unidad { get; set; }
    public bool Opcional { get; set; }

   
    public Recetas? _Receta { get; set; }
    public Ingredientes? _Ingrediente { get; set; }
}

// 8
public class Favoritos
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdReceta { get; set; }
    public DateTime FechaAgregado { get; set; }
    public bool Activo { get; set; }

   
    public Usuarios? _Usuario { get; set; }
    public Recetas? _Receta { get; set; }
}

// 9
public class Preparacion
{
    public int Id { get; set; }
    public int IdReceta { get; set; }
    public int NumeroPaso { get; set; }
    public string Descripcion { get; set; }
    public int TiempoEstimado { get; set; }

    
    public Recetas? _Receta { get; set; }
}

// 10
public class Reseñas
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdReceta { get; set; }
    public string Comentario { get; set; }
    public decimal Nota { get; set; }
    public DateTime FechaComentario { get; set; }

    
    public Usuarios? _Usuario { get; set; }
    public Recetas? _Receta { get; set; }
}

// 11
public class TablaNovedades
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaNovedad { get; set; }
    public int IdReceta { get; set; }
    public bool Activa { get; set; }

    
    public Recetas? _Receta { get; set; }
}

// 12
public class Utensilios
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Material { get; set; }
    public string Tamano { get; set; }
    public bool Disponible { get; set; }
    public int IdReceta { get; set; }
    
    public Recetas? _Receta { get; set; }
}

// 13
public class Tips
{
    public int Id { get; set; }
    public string Mejora { get; set; }
    public string Recomendacion { get; set; }
    public int IdReceta { get; set; }
    public DateTime Fecha { get; set; }

    
    public Recetas? _Receta { get; set; }
}

// 14
public class Diccionario
{
    public int Id { get; set; }
    public string Palabra { get; set; }
    public string Significado { get; set; }
}

// 15
public class Historial
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdReceta { get; set; }
    public DateTime FechaVisualizacion { get; set; }
    public int TiempoVisualizacion { get; set; }

    
    public Usuarios? _Usuario { get; set; }
    public Recetas? _Receta { get; set; }
}

// 16
public class PlanSemanal
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public decimal Presupuesto { get; set; }

    
    public Usuarios? _Usuario { get; set; }
}

// 17
public class Soporte
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string Asunto { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string Estado { get; set; }

    
    public Usuarios? _Usuario { get; set; }
    public List<Seguimiento>? Seguimientos { get; set; }
}

// 18
public class Seguimiento
{
    public int Id { get; set; }
    public int IdSoporte { get; set; }
    public string Comentario { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; }

   
    public Soporte? _Soporte { get; set; }
}

// 19
public class Notificaciones
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string Mensaje { get; set; }
    public DateTime Fecha { get; set; }
    public bool Leida { get; set; }

       public Usuarios? _Usuario { get; set; }
}

// 20
public class Preguntas
{
    public int Id { get; set; }
    public string Pregunta { get; set; }
    public string Respuesta { get; set; }
}