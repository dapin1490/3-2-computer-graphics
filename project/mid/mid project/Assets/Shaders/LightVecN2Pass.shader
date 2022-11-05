Shader "Custom/LightVecN2Pass"
{
	Properties
	{
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		// 1 pass
		cull front

		CGPROGRAM
		#pragma surface surf NoLight vertex:vert noambient noshadow

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		void vert(inout appdata_full v) {
			v.vertex.xyz += v.normal.xyz * 0.003;
		}

		void surf (Input IN, inout SurfaceOutput o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}

		float4 LightingNoLight(SurfaceOutput sf, float3 lightDr, float atten) {
			return float4(0, 0, 0, 1);
		}

		ENDCG

		// 2 pass
		cull back

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
			float result = dot(surfout.Normal, lightDir) * 0.5; // harf lambert
			
			return result;
		}

		ENDCG
	}
	FallBack "Diffuse"
}