namespace Elsa.Workflows.Management.Contracts;

/// <summary>
/// Represents a compression strategy.
/// </summary>
public interface ICompressionStrategy
{
    /// <summary>
    /// Compresses the input.
    /// </summary>
    ValueTask<string> CompressAsync(string input, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Decompresses the input.
    /// </summary>
    ValueTask<string> DecompressAsync(string input, CancellationToken cancellationToken = default);
}