// <copyright file="GameServerEndpoint.Generated.cs" company="MUnique">
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
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint"/>.
/// </summary>
[Table(nameof(GameServerEndpoint), Schema = SchemaNames.Configuration)]
internal partial class GameServerEndpoint : MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="Client"/>.
    /// </summary>
    public Guid? ClientId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="Client" />.
    /// </summary>
    [ForeignKey(nameof(ClientId))]
    public GameClientDefinition RawClient
    {
        get => base.Client as GameClientDefinition;
        set => base.Client = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.GameClientDefinition Client
    {
        get => base.Client;set
        {
            base.Client = value;
            this.ClientId = this.RawClient?.Id;
        }
    }

    /// <inheritdoc />
    public override MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint Clone(MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        var clone = new GameServerEndpoint();
        clone.AssignValuesOf(this, gameConfiguration);
        return clone;
    }
    
    /// <inheritdoc />
    public override void AssignValuesOf(MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint other, MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
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
