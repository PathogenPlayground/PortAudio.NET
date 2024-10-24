﻿using Biohazrd;
using Biohazrd.Transformation;

namespace PortAudioNet.Generator;

internal sealed class RemovePrefixesTransformation : TransformationBase
{
    private static TDeclaration StripPrefix<TDeclaration>(TDeclaration declaration, string prefix)
        where TDeclaration : TranslatedDeclaration
    {
        if (declaration.Name.StartsWith(prefix))
            return declaration with { Name = declaration.Name.Substring(prefix.Length) };
        else
            return declaration;
    }

    protected override TransformationResult TransformEnumConstant(TransformationContext context, TranslatedEnumConstant declaration)
        => StripPrefix(declaration, "pa");

    protected override TransformationResult TransformConstant(TransformationContext context, TranslatedConstant declaration)
        => StripPrefix(declaration, "pa");

    protected override TransformationResult TransformFunction(TransformationContext context, TranslatedFunction declaration)
        => StripPrefix(declaration, "Pa_");
}