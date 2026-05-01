#version 330 core
out vec4 FragColor;

in vec3 ourColor;

uniform vec3 overrideColor;
uniform int useOverrideColor;

void main()
{
    if (useOverrideColor == 1) {
        FragColor = vec4(overrideColor, 1.0);
    } else {
        FragColor = vec4(ourColor, 1.0);
    }
}