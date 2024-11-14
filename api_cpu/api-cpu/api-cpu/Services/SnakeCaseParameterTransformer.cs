using System.Text.RegularExpressions;

namespace api_cpu.Services
{
    public partial class SnakeCaseParameterTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            return value == null
                ? null
                : SnakeCaseParameterTransformer.Regex()
                    .Replace(value.ToString()!, "$1_$2")
                    .ToLower();
        }

        [GeneratedRegex("([a-z])([A-Z])")]
        private static partial Regex Regex();
    }
}
