// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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