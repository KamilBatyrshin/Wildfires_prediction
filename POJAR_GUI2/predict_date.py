import joblib
import numpy as np
import sys
import warnings

def main(predict_array):
    warnings.filterwarnings('ignore', category=UserWarning)
    if len(sys.argv) != 2:
        print("Ошибка: требуется 1 аргумент - массив характеристик")
        print(len(sys.argv))
        sys.exit(1)

    loaded_model = joblib.load(r'E:\Dipl\POJAR_REGR_UI\POJAR_GUI2\lightgbm_model_date.pkl')

    data_str = sys.argv[1]
    predict_array = np.array([float(x) for x in data_str.split(',')])

    reshaped_array = predict_array.reshape(-1,1)
    reshaped_array[1] = np.log2(reshaped_array[1])
    reshaped_array[2] = np.log2(reshaped_array[2])
    reshaped_array[3] = np.log2(reshaped_array[3])
    reshaped_array = predict_array.reshape(1,-1)

    prediction = loaded_model.predict(reshaped_array)
    prediction = np.round(prediction, 2)
    #true_predictions = np.pow(2, prediction)

    print(f"\nPrediction Result: {prediction[0]}")

if __name__ == "__main__":

    
    predict_array = sys.argv[1]
    #image_name = "E:/Dipl/test.jpg"

    main(predict_array)

