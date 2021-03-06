﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering
{
    internal static partial class ShaderMixins
    {
        internal partial class ParticleEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ParticleBaseEffect");
                context.Mixin(mixin, "ParticleComputeColorShader");
                if (context.GetParam(ParticleBaseKeys.BaseColor) != null)
                {

                    {
                        var __mixinToCompose__ = context.GetParam(ParticleBaseKeys.BaseColor);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "baseColor", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ParticleEffect", new ParticleEffect());
            }
        }
    }
}
