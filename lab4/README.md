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
            Since the mapping of the uv coordinates to the grid-like texture map isn't exact, a range of values corresponding to each "pixel" in the texture map is necessary. As a result, the function f(u) can be described as a piecewise function as follows:
            f(u) = {
                    0 if 0 <= u <= .125,
                    1 if .125 < u <= .25,
                    2 if .25 < u <= .375,
                    3 if .375 < u <= .5,
                    4 if .5 < u <= .625,
                    5 if .625 < u <= .75,
                    6 if .75 < u <= .875,
                    7 if .875 < u <= 1.0
                    }
        </p>
        
    </li>

    <li>
        <b>
            What is a formula to get the y coordinate of the texture given a v value of the uv coordinate (a value between 0 and 1)?
        </b>
        <br>
        <p>
            Similar to the above justification, the function f(v) can be described as a piecewise function. Unlike the mapping for the u coordinate, the v coordinate is in the inverse direction of its y-coordinate counterpart and must be adjusted:
            f(v) = {
                    7 if 0 <= u <= .125,
                    6 if .125 < u <= .25,
                    5 if .25 < u <= .375,
                    4 if .375 < u <= .5,
                    3 if .5 < u <= .625,
                    2 if .625 < u <= .75,
                    1 if .75 < u <= .875,
                    0 if .875 < u <= 1.0
                    }
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
