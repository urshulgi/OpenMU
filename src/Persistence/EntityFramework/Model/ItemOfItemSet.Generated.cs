// <copyright file="ItemOfItemSet.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model;

using System.ComponentModel.DataAnnotations.Schema;
using MUnique.OpenMU.Persistence;

/// <summary>
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.Items.ItemOfItemSet"/>.
/// </summary>
[Table(nameof(ItemOfItemSet), Schema = SchemaNames.Configuration)]
internal partial class ItemOfItemSet : MUnique.OpenMU.DataModel.Configuration.Items.ItemOfItemSet, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="ItemSetGroup"/>.
    /// </summary>
    public Guid? ItemSetGroupId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="ItemSetGroup" />.
    /// </summary>
    [ForeignKey(nameof(ItemSetGroupId))]
    public ItemSetGroup RawItemSetGroup
    {
        get => base.ItemSetGroup as ItemSetGroup;
        set => base.ItemSetGroup = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.Items.ItemSetGroup ItemSetGroup
    {
        get => base.ItemSetGroup;set
        {
            base.ItemSetGroup = value;
            this.ItemSetGroupId = this.RawItemSetGroup?.Id;
        }
    }

    /// <summary>
    /// Gets or sets the identifier of <see cref="ItemDefinition"/>.
    /// </summary>
    public Guid? ItemDefinitionId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="ItemDefinition" />.
    /// </summary>
    [ForeignKey(nameof(ItemDefinitionId))]
    public ItemDefinition RawItemDefinition
    {
        get => base.ItemDefinition as ItemDefinition;
        set => base.ItemDefinition = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition ItemDefinition
    {
        get => base.ItemDefinition;set
        {
            base.ItemDefinition = value;
            this.ItemDefinitionId = this.RawItemDefinition?.Id;
        }
    }

    /// <summary>
    /// Gets or sets the identifier of <see cref="BonusOption"/>.
    /// </summary>
    public Guid? BonusOptionId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="BonusOption" />.
    /// </summary>
    [ForeignKey(nameof(BonusOptionId))]
    public IncreasableItemOption RawBonusOption
    {
        get => base.BonusOption as IncreasableItemOption;
        set => base.BonusOption = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.Items.IncreasableItemOption BonusOption
    {
        get => base.BonusOption;set
        {
            base.BonusOption = value;
            this.BonusOptionId = this.RawBonusOption?.Id;
        }
    }

    /// <inheritdoc />
    public override MUnique.OpenMU.DataModel.Configuration.Items.ItemOfItemSet Clone(MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        var clone = new ItemOfItemSet();
        clone.AssignValuesOf(this, gameConfiguration);
        return clone;
    }
    
    /// <inheritdoc />
    public override void AssignValuesOf(MUnique.OpenMU.DataModel.Configuration.Items.ItemOfItemSet other, MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        base.AssignValuesOf(other, gameConfiguration);
        this.Id = other.GetId();
    }

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var baseObject = obj as IIdentifiable;
        if (baseObject != null)
        {
            return baseObject.Id == this.Id;
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    
}
