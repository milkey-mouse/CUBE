#include <stdio.h>
#include <stdlib.h>

#include <GL/glew.h>
#include <glfw3.h>
#include <glm/glm.hpp>

GLFWwindow *window;

int main(void)
{
	if (!glfwInit())
	{
		fputs("failed to initialize GLFW\n", stderr);
		return 1;
	}

	glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
	glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3);
	glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

	window = glfwCreateWindow(1024, 768, "rube", NULL, NULL);
	if (window == NULL)
	{
		fputs("failed to open window\n", stderr);
		glfwTerminate();
		return 1;
	}
	glfwMakeContextCurrent(window);

	if (glewInit() != GLEW_OK)
	{
		fputs("Failed to initialize GLEW\n", stderr);
		glfwTerminate();
		return 1;
	}

	//glfwSetInputMode(window, GLFW_STICKY_KEYS, GL_TRUE);

	glClearColor(1, 0, 0, 0);

	while (!glfwWindowShouldClose(window))
	{
		glClear(GL_COLOR_BUFFER_BIT);

		glfwSwapBuffers(window);
		glfwPollEvents();
	}

	glfwTerminate();
	return 0;
}
