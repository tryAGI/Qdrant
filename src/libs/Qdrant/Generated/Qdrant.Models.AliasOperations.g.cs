#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Group of all the possible operations related to collection aliases
    /// </summary>
    public readonly partial struct AliasOperations : global::System.IEquatable<AliasOperations>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.CreateAliasOperation? CreateOperation { get; init; }
#else
        public global::Qdrant.CreateAliasOperation? CreateOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateOperation))]
#endif
        public bool IsCreateOperation => CreateOperation != null;

        /// <summary>
        /// Delete alias if exists
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DeleteAliasOperation? DeleteOperation { get; init; }
#else
        public global::Qdrant.DeleteAliasOperation? DeleteOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteOperation))]
#endif
        public bool IsDeleteOperation => DeleteOperation != null;

        /// <summary>
        /// Change alias to a new one
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.RenameAliasOperation? RenameOperation { get; init; }
#else
        public global::Qdrant.RenameAliasOperation? RenameOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenameOperation))]
#endif
        public bool IsRenameOperation => RenameOperation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasOperations(global::Qdrant.CreateAliasOperation value) => new AliasOperations((global::Qdrant.CreateAliasOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.CreateAliasOperation?(AliasOperations @this) => @this.CreateOperation;

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(global::Qdrant.CreateAliasOperation? value)
        {
            CreateOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasOperations(global::Qdrant.DeleteAliasOperation value) => new AliasOperations((global::Qdrant.DeleteAliasOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DeleteAliasOperation?(AliasOperations @this) => @this.DeleteOperation;

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(global::Qdrant.DeleteAliasOperation? value)
        {
            DeleteOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasOperations(global::Qdrant.RenameAliasOperation value) => new AliasOperations((global::Qdrant.RenameAliasOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.RenameAliasOperation?(AliasOperations @this) => @this.RenameOperation;

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(global::Qdrant.RenameAliasOperation? value)
        {
            RenameOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(
            global::Qdrant.CreateAliasOperation? createOperation,
            global::Qdrant.DeleteAliasOperation? deleteOperation,
            global::Qdrant.RenameAliasOperation? renameOperation
            )
        {
            CreateOperation = createOperation;
            DeleteOperation = deleteOperation;
            RenameOperation = renameOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RenameOperation as object ??
            DeleteOperation as object ??
            CreateOperation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateOperation?.ToString() ??
            DeleteOperation?.ToString() ??
            RenameOperation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateOperation || IsDeleteOperation || IsRenameOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.CreateAliasOperation?, TResult>? createOperation = null,
            global::System.Func<global::Qdrant.DeleteAliasOperation?, TResult>? deleteOperation = null,
            global::System.Func<global::Qdrant.RenameAliasOperation?, TResult>? renameOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateOperation && createOperation != null)
            {
                return createOperation(CreateOperation!);
            }
            else if (IsDeleteOperation && deleteOperation != null)
            {
                return deleteOperation(DeleteOperation!);
            }
            else if (IsRenameOperation && renameOperation != null)
            {
                return renameOperation(RenameOperation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.CreateAliasOperation?>? createOperation = null,
            global::System.Action<global::Qdrant.DeleteAliasOperation?>? deleteOperation = null,
            global::System.Action<global::Qdrant.RenameAliasOperation?>? renameOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateOperation)
            {
                createOperation?.Invoke(CreateOperation!);
            }
            else if (IsDeleteOperation)
            {
                deleteOperation?.Invoke(DeleteOperation!);
            }
            else if (IsRenameOperation)
            {
                renameOperation?.Invoke(RenameOperation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateOperation,
                typeof(global::Qdrant.CreateAliasOperation),
                DeleteOperation,
                typeof(global::Qdrant.DeleteAliasOperation),
                RenameOperation,
                typeof(global::Qdrant.RenameAliasOperation),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AliasOperations other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.CreateAliasOperation?>.Default.Equals(CreateOperation, other.CreateOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DeleteAliasOperation?>.Default.Equals(DeleteOperation, other.DeleteOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.RenameAliasOperation?>.Default.Equals(RenameOperation, other.RenameOperation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AliasOperations obj1, AliasOperations obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AliasOperations>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AliasOperations obj1, AliasOperations obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AliasOperations o && Equals(o);
        }
    }
}
