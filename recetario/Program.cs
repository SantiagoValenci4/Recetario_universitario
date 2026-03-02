// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1. Usuarios
public class Usuarios
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int IdUniversidad { get; set; }
    public string Numero { get; set; }
    public string Correo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Activo { get; set; }
}

// 2. Universidad
public class Universidad
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Ciudad { get; set; }
    public string Pais { get; set; }
    public DateTime FechaRegistro { get; set; }
}

// 3. Recetario
public class Recetario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool EsPublico { get; set; }
}

// 4. Moderador 
public class Moderador
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string AreaAsignacion { get; set; }
}

// 5. Recetas
public class Recetas
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Foto { get; set; }
    public int IdCategoria { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaCreacion { get; set; }
}

// 6. Categorias
public class Categorias
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Tipo { get; set; }
    public bool Activa { get; set; }
}

// 7. Ingredientes
public class Ingredientes
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Estado { get; set; }
    public decimal PrecioPromedio { get; set; }
    public decimal Cantidad { get; set; }
}

// 8. Favoritos
public class Favoritos
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdReceta { get; set; }
    public DateTime FechaAgregado { get; set; }
    public bool Activo { get; set; }
}

// 9. Preparacion
public class Preparacion
{
    public int Id { get; set; }
    public int IdReceta { get; set; }
    public int NumeroPaso { get; set; }
    public string Descripcion { get; set; }
    public int TiempoEstimado { get; set; }
}

// 10. Reseñas
public class Reseñas
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdReceta { get; set; }
    public string Comentario { get; set; }
    public decimal Nota { get; set; }
    public DateTime FechaComentario { get; set; }
}

// 11. TablaNovedades
public class TablaNovedades
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaNovedad { get; set; }
    public int IdReceta { get; set; }
    public bool Activa { get; set; }
}

// 12. Utensilios
public class Utensilios
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Material { get; set; }
    public string Tamano { get; set; }
    public bool Disponible { get; set; }
}

// 13. Tips
public class Tips
{
    public int Id { get; set; }
    public string Mejora { get; set; }
    public string Recomendacion { get; set; }
    public int IdReceta { get; set; }
    public DateTime Fecha { get; set; }
}

// 14. Diccionario 
public class Diccionario
{
    public int Id { get; set; }
    public string Palabra { get; set; }
    public string Significado { get; set; }
}

// 15. Historial
public class Historial
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdReceta { get; set; }
    public DateTime FechaVisualizacion { get; set; }
    public int TiempoVisualizacion { get; set; }
}

// 16. PlanSemanal
public class PlanSemanal
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public decimal Presupuesto { get; set; }
}

// 17. Soporte
public class Soporte
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string Asunto { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string Estado { get; set; }
}

// 18. Seguimiento
public class Seguimiento
{
    public int Id { get; set; }
    public int IdSoporte { get; set; }
    public string Comentario { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; }
}

// 19. Notificaciones
public class Notificaciones
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string Mensaje { get; set; }
    public DateTime Fecha { get; set; }
    public bool Leida { get; set; }
}

// 20. Preguntas 
public class Preguntas
{
    public int Id { get; set; }
    public string Pregunta { get; set; }
    public string Respuesta { get; set; }
}