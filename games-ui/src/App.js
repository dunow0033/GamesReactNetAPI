import React from "react";
import { Route, BrowserRouter as Router, Routes } from "react-router-dom";

import MainPage from "./Pages/MainPage"
import GamePage from "./Pages/GamePage";
import NotFoundPage from "./Pages/NotFoundPage";

function App() {
  return (
    <>
      <Router>
        <Routes>
          <Route path="/" element={<MainPage />}></Route>
          <Route path="/GameModel/:id" element={<GamePage />} />
          <Route path="*" element={<NotFoundPage />} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
