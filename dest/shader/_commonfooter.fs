
void main()
{
    vec4 color = vec4(1);
    mainImage(color, gl_FragCoord.xy);
    outColor = color;
}