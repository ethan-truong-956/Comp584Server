using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WorldModel;

[Table("city")]
public partial class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("countryid")]
    public int Countryid { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("latitude")]
    public int Latitude { get; set; }

    [Column("longtitude")]
    public int Longtitude { get; set; }

    [Column("population")]
    public int Population { get; set; }

    [ForeignKey("Countryid")]
    [InverseProperty("Cities")]
    public virtual Country Country { get; set; } = null!;
}
