using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace EasyAbp.DynamicForm.Web.Pages.DynamicForm.FormTemplates.FormItemTemplate.ViewModels;

public class CreateFormItemTemplateViewModel
{
    [Display(Name = "FormItemTemplateName")]
    public string Name { get; set; }

    [Display(Name = "FormItemTemplateInfoText")]
    public string InfoText { get; set; }

    [Required]
    [SelectItems("FormItemTypes")]
    [Display(Name = "FormItemTemplateType")]
    public string Type { get; set; }

    [Display(Name = "FormItemTemplateOptional")]
    public bool Optional { get; set; }

    [Display(Name = "FormItemTemplateConfigurations")]
    [TextArea]
    public string Configurations { get; set; }

    /// <summary>
    /// Split available values with commas.
    /// </summary>
    [Display(Name = "FormItemTemplateAvailableValues")]
    [InputInfoText("FormItemTemplateAvailableValuesInfo")]
    public string AvailableValues { get; set; }

    [Display(Name = "FormItemDisplayOrder")]
    public int DisplayOrder { get; set; }
}