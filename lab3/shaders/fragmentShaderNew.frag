uniform vec3 colorAn;
uniform vec3 colorBn;
uniform float time;

varying vec3 vUv;

void main() 
{
  gl_FragColor = vec4(sin(-time), cos(time), sin(time), 1.0);
  if (cos(2.0 * vUv.y * time) < 0.0) 
  {
    discard;
  }
}
