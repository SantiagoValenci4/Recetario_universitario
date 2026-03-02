// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Usuarios //1
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string universidad {get; set;}
    public string numero {get; set;}
    public string correo {get; set;}
    public DateTime fecha_nacimiento {get; set;}

    
}

public class  Universidad //2
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string ciudad {get; set;}
    public string pais {get; set;}
    public DateTime fecha_registro {get; set;}
}

public class  Recetario //3
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string Descripcion {get; set;}
    public int Id_usuario {get; set;}
    public DateTime fecha_creacion {get; set;}
    public bool publica { get; set; }
} 

public class  Moderador  //4
{
    public int Id {get; set;}
    public int Id_usuario {get; set;}
    public string NivelPermiso {get; set;}
    public bool fechaAsignacion {get; set;}
    public bool activo {get; set;}
}
public class Recetas  //5
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string Descripcion {get; set;}
    public string Ingredientes {get; set;}
    public string Utencilios {get; set;}
}

public class Categorias  //6
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string Descripcion {get; set;}
    public string Tipo {get; set;}
    public bool activa {get; set;}
}
public class Ingredientes //7
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string calorias {get; set;}
    public string precio_promedio {get; set;}
    public string cantidad {get; set;}
}

public class Favoritos    //8
{
    public int Id {get; set;}
    public int Id_usuario{get; set;}
    public int Id_receta {get; set;}
    public string nombre { get; set;}
    public DateTime fechaAgregado {get; set;}
    
}

public class  Preparacion  //9
{
    public int Id {get; set;}
    public int Id_receta {get; set;}
    public string pasoNumero {get; set;}
    public string descripcion {get; set;}
    public string tiempo {get; set;}
}

public class  Reseñas    //10
{
    public int Id {get; set;}
    public int Id_usuario{get; set;}
    public int Id_receta{get; set;}
    public string comentario {get; set;}
    public decimal puntiacion {get; set;}
    public DateTime fechaComentario {get; set;}
}

public class  Tabla_novedades  //11
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string Descripcion {get; set;}
    public string Ingredientes {get; set;}
    public string Utencilios {get; set;}
}

public class  Utencilios    //12
{
    public int Id {get; set;}
    public string nombre {get; set;}
    public string Descripcion {get; set;}
}

public class Tips   //13
{
    public int Id {get; set;}
    public int Id_usuario {get; set;}
    public int Id_receta {get; set;}
    public string titulo {get; set;}
    public string Descripcion {get; set;}
    
    
}

public class  Diccionario   //14
{
    public int Id {get; set;}
    public int Id_usuario {get; set;}
    public string palabra {get; set;}
    public string definicion {get; set;}
    
}

public class  Historial  //15
{
    public int Id {get; set;}
    public int Id_usuario {get; set;}
    public int Id_receta {get; set;}
    public DateTime fechaVisualizacion {get; set;}
  
}

public class  Plan_semanal //16
{
    public int Id {get; set;}
    public int Id_usuario{get; set;}
    public int Id_receta {get; set;}
    public DateTime fechaInicio{get; set;}
    public DateTime fechaFin{get; set;}
    public string presupuesto {get; set;}

}

public class  Soporte  //17
{
    public int Id {get; set;}
    public int Id_usuario {get; set;}
    public string asunto {get; set;}
    public string descripcion {get; set;}
    public DateTime fechaCreacion  {get; set;}
    public bool estado {get; set;}
}

public class  Seguimiento //18
{

}

public class  Notificaciones //19
{

}

public class  Preguntas //20
{

}