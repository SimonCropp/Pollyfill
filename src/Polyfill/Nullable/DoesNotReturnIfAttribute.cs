#if(NETSTANDARD2_0 || NETFRAMEWORK || NETCOREAPP2_1 || NETCOREAPP2_0 || NETCOREAPP2_2)

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
///   Specifies that the method will not return if the associated <see cref="Boolean"/>
///   parameter is passed the specified value.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter)]
sealed class DoesNotReturnIfAttribute : Attribute
{
    /// <summary>
    ///   Gets the condition parameter value.
    ///   Code after the method is considered unreachable by diagnostics if the argument
    ///   to the associated parameter matches this value.
    /// </summary>
    public bool ParameterValue { get; }

    /// <summary>
    ///   Initializes a new instance of the <see cref="DoesNotReturnIfAttribute"/>
    ///   class with the specified parameter value.
    /// </summary>
    /// <param name="parameterValue">
    ///   The condition parameter value.
    ///   Code after the method is considered unreachable by diagnostics if the argument
    ///   to the associated parameter matches this value.
    /// </param>
    public DoesNotReturnIfAttribute(bool parameterValue) =>
        ParameterValue = parameterValue;
}

#endif