CMPM163: Graphics and Real-Time Rendering
Lab4: Textures & Normal Maps
<br>
<b>Questions:</b>
<ol>
    <li>
        <b>
            What is a formula to get the x coordinate of the texture given a u value of the uv coordinate (a value between 0 and 1)?
        </b>
        <br>
        <p>
            Since the v-axis is the x-axis scaled by a factor of 7, the corresponding function is:
            f(u) = 7u
        </p>
        
 </li>
 <li>
     <li>
        <b>
            What is a formula to get the y coordinate of the texture given a v value of the uv coordinate (a value between 0 and 1)?
        </b>
        <br>
        <p>
            Unlike the relationship between the x-axis and the u-axis, the v-axis is the inverse of the y-axis in. As a result, the v-coordinate must be subtracted from 1 to get the equivalent coordinate in y. 
            f(v) = 7(1-v)
        </p>
</li>
    
<li>
        <b>
            What color is sampled from the texture at the uv coordinate (0.375, 0.25)? (sample from the image based on the number your formula gives you i.e. (1, 0) (x, y) is blue)
        </b>
        <br>
        <p>
            The color sampled from the texture at uv coordinate (0.375, 0.25) is gray.
        </p>
    </li>
</ol>


<b>Five Cubes Link:</b>
<br>
<b>Five Cubes Descriptions</b>
<p>
<ul>
<li>
Center Cube: uses built-in texture functionalityTHREE.MeshPhongMaterial() that equips '161b.jpg' texture with corresponding map '161b_norm.jpg'.three.js 
</li>
<li>
Left Center Cube: uses three.js built in texture functionality THREE.MeshPhongMaterial() that loads just the texture 
</li>
<li>
Right Center Cube: uses built-in texture functionalityTHREE.MeshPhongMaterial() that equips '172.jpg' texture with corresponding map '172_norm.jpg'.three.js 
</li>
<li>
Top Middle Cube: uses custom-built fragement and vertex shader described in assignment. The vertex shader passes the uv-coordinates to the fragment shader so that the fragment shader can perform a 1-to-1 mapping with the texture using the new uv-coordinates to place the texture on the cube.
</li>
<li>
Bottom Middle Cube: the fragment shader multiplies the vec2 by a magnitude of 2. Doing so "shrinks" the mapping area down to the bottom left corner of the cube, effectively making it a quarter of the geometry. Then, it subtracts 1.0 depending on if the x or y coordinate is greater than 1 to ensure that the values retrieved and mapped are within bounds.
</li>
</p>

