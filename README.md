# Sogeti-Rest-API-basic
Basic rest api endpoint for Sogeti tech team review


I have this tested in postman

  Create - POST - https://localhost:5001    
    body ex:      {
                      "customerId": 999,
                      "orderName": "TestPost"
                  }
  
  GetAll(for debugging) - GET - https://localhost:5001/orders
  
  GetByCustomer - GET - https://localhost:5001?custId=2     where custId=? is customer id
  
  Delete/Cancel Order - DELETE - https://localhost:5001?ordId=5   where ordId=? is order id
  
  Update Order - PUT - https://localhost:5001 
      body ex:    {
                      "orderId": 8,
                      "customerId": 9090,
                      "orderName": "TestUpdate"
                  }
  
