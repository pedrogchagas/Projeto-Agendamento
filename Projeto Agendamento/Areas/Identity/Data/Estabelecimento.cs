using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Projeto_Agendamento.Areas.Identity.Data;

public class Estabelecimento
{
    [Key]
    [DisplayName("Código")]
    public int ID_Estabelecimento { get; set; }

    [DisplayName("Data de Cadastro")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public System.DateTime DataCadastro { get; set; }

    [DisplayName("Data de Atualização")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public System.DateTime DataAtualizacao { get; set; }

    [DisplayName("CPF CNPJ")]
    [StringLength(20, ErrorMessage = "20 caracteres")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string CNPJ { get; set; }

    [DisplayName("Nome do Estabelecimento")]
    [StringLength(150, ErrorMessage = "150 caracteres")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string NomeEstabelecimento { get; set; }

    [DisplayName("Razão Social")]
    [StringLength(150, ErrorMessage = "150 caracteres")]
    public string? RazaoSocial { get; set; }

    [DisplayName("Logradouro")]
    [StringLength(100, ErrorMessage = "100 caracteres")]
    public string? Logradouro { get; set; }

    [DisplayName("Número")]
    [StringLength(10, ErrorMessage = "10 caracteres")]
    public string? Numero { get; set; }

    [DisplayName("Bairro")]
    [StringLength(50, ErrorMessage = "50 caracteres")]
    public string? Bairro { get; set; }

    [DisplayName("Complemento")]
    [StringLength(150, ErrorMessage = "150 caracteres")]
    public string? Complemento { get; set; }

    [DisplayName("CEP")]
    [StringLength(10, ErrorMessage = "8 caracteres")]
    public string? CEP { get; set; }

    [DisplayName("Telefone")]
    [StringLength(50, ErrorMessage = "50 caracteres")]
    public string? TelefoneContato { get; set; }

    [DisplayName("Email")]
    [StringLength(250, ErrorMessage = "250 caracteres")]
    public string Email { get; set; }

    //Relacionamento
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}
