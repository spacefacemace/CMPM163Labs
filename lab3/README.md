CMPM163: Graphics and Real-Time Rendering 
<br>
Lab3:  Materials & Shaders in Three.js

Cubes: https://drive.google.com/file/d/190aX0pxiaj1aOJxD1mzd7DzF1nZeIHT1/view?usp=sharing

Striped Cube: I introduced the Clock functionality from Three.js. Using the 'time' variable in my fragment shader, I was able to make the colors pulsate on a regular interval (bounded by trigonometric functions so that they don't just turn white and stay white). To make the striped effect, I used the function (cos(2.0 * vUv.y * time) < 0.0) to instruct the fragment shader to discard every other rendered line.

Big Transparent Cube: I used the same code for the tutorial cube but changed the scale to double the size. I also used the transparent attribute of the Three.js shader to make the tutorial cube visible in the center.

Three.js Tutorial Cube: Just followed the instructions for the Three.js shaded cube in the lab handout!

Shader Cube: Just followed the instructions for the vertex + fragment shader in the lab handout! Changed its colors in the uniform declaration. 


