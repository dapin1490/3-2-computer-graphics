Shader "Custom/LightVector"
{
	Properties
	{
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		CGPROGRAM
		#pragma surface surf ExLambert

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}

		float4 LightingExLambert(SurfaceOutput surfout, float3 lightDir, float atten) {
			//float result = dot(surfout.Normal, lightDir);
			//result = saturate(result) + 0.5;
			
			//float result = dot(surfout.Normal, lightDir) * 0.5 + 0.5; // harf lambert

			float result = saturate(dot(surfout.Normal, lightDir));
			float4 final;
			final.rgb = surfout.Albedo * result;
			final.a = surfout.Alpha;
			
			return final;

			//float result = dot(surfout.Normal, lightDir) * 0.5; // harf lambert
			
			//return result;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
