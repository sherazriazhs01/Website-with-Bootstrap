 /* Custom styles */
    html {
      scroll-behavior: smooth;
    }
    body {
      font-family: 'Poppins', sans-serif;
      background: linear-gradient(135deg, #f8f4f2, #ffffff);
    }
    .hero {
    height: 165vh; /* Carousel Height Increased */
    color: white;
    text-shadow: 2px 2px 10px rgba(0,0,0,0.8);
    border-radius: 20px; /* Rounded Corners */
  }

  /* For Mobile Responsive Height */
  @media (max-width: 768px) {
    .hero {
      height: 100vh; /* Mobile screen ke liye full screen */
    }
  }

  #heroCarousel .carousel-inner {
    border-radius: 20px;
  }
    .menu-item img {
      height: 200px;
      object-fit: cover;
      transition: transform 0.3s ease;
    }
    .menu-item img:hover {
      transform: scale(1.05);
    }
    .btn-primary:hover {
      background-color: #ff6f61;
      border-color: #ff6f61;
      transform: scale(1.05);
      transition: 0.3s;
    }
    footer {
      background-color: #343a40;
    }