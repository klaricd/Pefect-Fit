Shader "Custom/Opaque" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Color("Color", Color)=(1.0, 1.0, 1.0, 1.0)
	}

	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 150
 
		CGPROGRAM
		#pragma surface surf Lambert noforwardadd
 
		sampler2D _MainTex;
		fixed4 _Color;

		struct Input {
			float2 uv_MainTex;
		};
 
		void surf (Input IN, inout SurfaceOutput o) {
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * float4(_Color.r, _Color.g, _Color.b, 1);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
 
	Fallback "Mobile/VertexLit"
}