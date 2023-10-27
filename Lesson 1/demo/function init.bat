function init() {
    // Create a scene
    var scene = new THREE.Scene();
  
    // Create a camera
    var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 1, 1000);
    camera.position.set(0, 0, 500);
  
    // Create a renderer
    var renderer = new THREE.WebGLRenderer();
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);
  
    // Create a plane
    var planeGeometry = new THREE.PlaneGeometry(500, 500, 1, 1);
    var planeMaterial = new THREE.MeshPhongMaterial({color: 0xffffff});
    var plane = new THREE.Mesh(planeGeometry, planeMaterial);
    scene.add(plane);
  
    // Create a cube
    var cubeGeometry = new THREE.BoxGeometry(100, 100, 100);
    var cubeMaterial = new THREE.MeshPhongMaterial({color: 0xff0000});
    var cube = new THREE.Mesh(cubeGeometry, cubeMaterial);
    scene.add(cube);
  
    // Create a light
    var light = new THREE.DirectionalLight(0xffffff, 1);
    light.position.set(0, 0, 1000);
    scene.add(light);
  
    // Create a clock
    var clock = new THREE.Clock();
  
    // Create an animation loop
    function animate() {
      // Update the clock
      clock.tick();
  
      // Update the camera
      camera.position.x += (100 * clock.getDelta());
      camera.position.y += (100 * clock.getDelta());
  
      // Render the scene
      renderer.render(scene, camera);
  
      // Request the next animation frame
      requestAnimationFrame(animate);
    }
  
    // Start the animation loop
    animate();
  }
  
  window.addEventListener('load', init);
  