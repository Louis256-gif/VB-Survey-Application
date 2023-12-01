public class SurveySystemForm
'declare properties
Private customerName as String 
Private telephone as String
Private emailaddress as String
private feedback as String

'products and prices
Private mensShoesPrice as Decimal = 450000
private weddingDressPrice as Decimal = 150000

'methods
private Sub CalculateTotalAmount(ByVal mensShoesQuantity as Integer, Byval weddingDressQuantity as Integer)
    Dim totalAmount as Decimal = (mensShoesQuantity = mensShoesPricw) + (weddingDressQuantity * weddingDressPrice)
    MessageBox.Show($"Total Amount: {totalAmount} shs")
End Sub

private Sub SubmitButton_Click(Sender as Object, e as EventArgs) Handles SubmitButton.Click)
    'Retrieve values from input fields
    customerName = CustomerNameTextBox.Text
    telephone = TelephoneTextBOx.Text
    emailAddress = EmailAddressTxtBox.Text
    feedback = Feedback.TextBox.Text

    'Asume the customer buys 2 pairs of mrn's shoes and 1 wedding dress 
    CalculateTotalAmount(2, 1)


'Include responses to service-related quetsions in feedback
feedback &= vbcrLf & "Service Satisfaction: " & GetQuestionResponse(ServiceQuestionGroupBox)
feedback &= vbcrLf & "Product Quantity: " & GetQuestionResponse(ProductQualityGroupBox)
feedback &= vbcrLf & "Overall Experience: " & GetQuestionResponse(OverallExperience) 

'display feedback
MessageBox.Show($"Feedback received:{vbCrLf}{feedback}")

'clear input fields
ClearFields()
End Sub

   private sub ClearButton_Click(Sender As Object, e As EventArgs) Handles ClearButton.Click
      'clear input fields and radio buttons
      ClearFields()
      clearRadioButtons(ServiceQuestionGroupBox)
      clearRadioButtons(ProductQualityGroupBox)
      clearRadioButtons(OverallExperience)
End Sub

private Sub ClearFields()
       CustomerNameTextBox.Clear()
       TelephoneTextBOx.Clear()
       EmailAddressTxtBox.Clear()
       feedbackTextBox.Clear()
    
End Sub
       'Helper method to get selected response from a group of radio buttons
       private Function GetQuestionResponse(groupBox As GroupBox) As String
         For Each control As control In groupBox.controls
          If TypeOf control Is RadioButton Then 
           Dim radioButton As RadioButton = DirectCsat(Control, RadioButton)
             raioButton.Checked = False
         End If
     Next 
  End Sub
  End class



