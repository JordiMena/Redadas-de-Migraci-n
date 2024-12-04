using System.ComponentModel.DataAnnotations;

public class Redadas{
    public string Id { get; set; } = string.Empty;
    public DateTime FechaDetencion { get; set; } = DateTime.Now;
    public string Nombre { get; set;} = "";
    public string Apellido { get; set; } = "";
    public string Cedula { get; set;} = "";
    [Required(ErrorMessage = "Es de requerimiento un motivo")]
    public string Motivo { get; set; } = "";
    
    
}