import React, { useState } from 'react';

const CurrencyConvertor = () => {
  const [amount, setAmount] = useState('');
  const [currency, setCurrency] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    if (currency.toLowerCase() === 'euro') {
      const euroValue = parseFloat(amount) * 80; // Example: 1 Euro = ₹80
      alert(`Converting to Euro Amount is ${euroValue}`);
    } else {
      alert("Please type 'Euro' as currency to convert.");
    }
  };

  return (
    <div>
      <h1 style={{ color: 'green' }}>Currency Convertor!!!</h1>
      <form onSubmit={handleSubmit}>
        <label>Amount: </label>
        <input
          type="number"
          value={amount}
          onChange={(e) => setAmount(e.target.value)}
          required
        />
        <br /><br />
        <label>Currency: </label>
        <textarea
          value={currency}
          onChange={(e) => setCurrency(e.target.value)}
          required
        />
        <br /><br />
        <button type="submit">Submit</button>
      </form>
    </div>
  );
};

export default CurrencyConvertor;
