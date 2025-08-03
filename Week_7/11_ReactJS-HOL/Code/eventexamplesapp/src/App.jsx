import React, { useState } from 'react';
import CurrencyConvertor from './CurrencyConvertor';

const App = () => {
  const [counter, setCounter] = useState(0);

  // Increment logic and Hello alert
  const handleIncrement = () => {
    incrementCounter();
    sayHello();
  };

  const incrementCounter = () => {
    setCounter(prev => prev + 1);
  };

  const decrementCounter = () => {
    setCounter(prev => prev - 1);
  };

  const sayHello = () => {
    alert("Hello! Member1");
  };

  const sayWelcome = (msg) => {
    alert(msg);
  };

  const handleClick = () => {
    alert("I was clicked");
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      {/* Counter Display */}
      <h2>{counter}</h2>

      {/* Buttons */}
      <button onClick={handleIncrement}>Increment</button><br /><br />
      <button onClick={decrementCounter}>Decrement</button><br /><br />
      <button onClick={() => sayWelcome("welcome")}>Say welcome</button><br /><br />
      <button onClick={handleClick}>Click on me</button>

      <hr />

      {/* Currency Component */}
      <CurrencyConvertor />
    </div>
  );
};

export default App;
