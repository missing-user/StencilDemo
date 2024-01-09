Shader "Unlit/Stencil1"
{
    Properties
    {
    }
    SubShader
    {
        Tags { 
            "RenderType"="Opaque"
            "Queue"="Geometry"
            "RenderPipeline"="UniversalPipeline"
        }
        LOD 100

        Pass
        {
        	Blend Zero One
            ZWrite Off

            Stencil
            {
                // if True
                //    stencil buffer = 1
                Ref 1
                Comp Always
                Pass Replace
                Fail Keep
            }
        }
    }
}
