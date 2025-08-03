import React from 'react';

const OfficeCard = () => {
  const itemName = {
    Name: 'Office Space',
    Rent: 50000,
    Address: 'Chennai',
    img: 'https://images.globest.com/contrib/content/uploads/sites/304/2021/02/empty-office-resized.jpg'
  };

  // Conditional CSS class or inline style
  const textRed = { color: 'red' };
  const textGreen = { color: 'green' };

  const rentStyle = itemName.Rent <= 60000 ? textRed : textGreen;

  return (
    <div style={{ fontFamily: 'Arial', padding: '20px' }}>
      {/* Display element */}
      <h1>{itemName.Name}, at Affordable Range</h1>

      {/* JSX Attribute */}
      <img src={itemName.img} height="25%" alt="Office Space" />

      {/* Display Object Values */}
      <h2>Name: {itemName.Name}</h2>
      <h3 style={rentStyle}>Rent: ₹{itemName.Rent}</h3>
      <h3>Address: {itemName.Address}</h3>
    </div>
  );
};

export default OfficeCard;
