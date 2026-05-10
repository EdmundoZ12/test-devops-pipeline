using System.ComponentModel.DataAnnotations;

namespace TestDevops.Models.Dto;


public class CreateCategoryDto
{
    [Required(ErrorMessage = "Category name is required")]
    [MaxLength(50, ErrorMessage = "Category name cannot exceed 50 characters")]
    [MinLength(3, ErrorMessage = "Category name cannot exceed 3 characters")]
    public string Name { get; set; } = string.Empty;
}