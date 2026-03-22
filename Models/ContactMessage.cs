using System.ComponentModel.DataAnnotations;

public class ContactMessage
{
    [Required(ErrorMessage = "Por favor, escribe tu nombre.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Escribe un correo válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cuéntame un poco sobre tu proyecto o duda.")]
    [StringLength(500, ErrorMessage = "El mensaje es muy largo (máximo 500 caracteres).")]
    public string Message { get; set; } = string.Empty;
}

