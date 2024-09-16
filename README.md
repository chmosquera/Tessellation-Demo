# Tessellation Demo

This project implements a tessellation technique for generating high-detailed meshes dynamically at runtime using Unity and Shader Graphs.

By using displacement maps and a tessellation shader, this project turns a simple sphere into a high-detailed fungal shape. To optimize the performance hit that's caused by more vertices, a view-based tessellation technique is used. This approach does more tessellation along the edges of the mesh, where the shape is more pronounced. The front-facing areas receives less tessellation because the detail is not as visually impactful from that perspective.

[![Watch the video](https://img.youtube.com/vi/myDzEevNtfY/hqdefault.jpg)](https://youtu.be/myDzEevNtfY)

## Resources
- [Tessellation and Displacement - Shader Graph Basics - Episode 41](https://www.youtube.com/watch?v=ycJ434Lh21w&t=923s&ab_channel=BenCloward)