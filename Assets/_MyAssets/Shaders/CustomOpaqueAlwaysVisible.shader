Shader "Custom/OpaqueAlwaysVisible" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Color("Color", Color)=(1.0, 1.0, 1.0, 1.0)
		_SilhouetteColor("Silhouette color", Color)=(1.0, 1.0, 1.0, 1.0)
	}

	SubShader {
		Tags { "RenderType"="Transparent" }
		LOD 150
 
		Pass {
			Cull Off
			ZWrite Off
			ZTest Always
			Blend SrcAlpha OneMinusSrcAlpha

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
			};

			float4 _SilhouetteColor;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				return _SilhouetteColor;
			}
			ENDCG
		}

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